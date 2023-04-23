using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using LaboratoryWork3.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace LaboratoryWork3.Models.Services
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly AppDbContext _dbContext;
        private readonly LocalStorageService _localStorageService;

        private ClaimsIdentity _identity;

        public CustomAuthenticationStateProvider(AppDbContext dbContext, LocalStorageService localStorage)
        {
            _dbContext = dbContext;
            _localStorageService = localStorage;

            _ = LoadAuthenticationStateAsync();
        }

        public async Task<bool> IsAuthenticatedAsync()
        {
            return _identity != null && _identity.IsAuthenticated;
        }

        public async Task<bool> Login(User user)
        {
            User dbUser = null;

            var users = await _dbContext.Users.ToListAsync();
            foreach (var u in users)
            {
                if (u.Email.Equals(user.Email) && u.Password == user.Password)
                {
                    dbUser = u;
                    break;
                }
            }

            if (dbUser != null)
            {
                _identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, dbUser.Email),
                }, "apiauth_type");

                await _localStorageService.SetItemAsync("userEmail", dbUser.Email);
                NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
                return true;
            }
            return false;
        }


        public async Task Logout()
        {
            _identity = new ClaimsIdentity();
            await _localStorageService.RemoveItemAsync("userEmail");
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }

        public async Task<bool> SignUp(User user)
        {
            var existingUser = false;

            var users = await _dbContext.Users.ToListAsync();
            foreach (var u in users)
            {
                if (u.Email == user.Email)
                {
                    existingUser = true;
                    break;
                }
            }

            if (!existingUser)
            {
                _dbContext.Users.Add(user);
                await _dbContext.SaveChangesAsync();
                return true;
            }

            return false;
        }


        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            if (_identity == null || !_identity.IsAuthenticated)
            {
                return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity())));
            }
            else
            {
                return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(_identity)));
            }
        }

        private async Task LoadAuthenticationStateAsync()
        {
            var userEmail = await _localStorageService.GetItemAsync("userEmail");

            if (!string.IsNullOrEmpty(userEmail))
            {
                _identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, userEmail),
                }, "apiauth_type");

                NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
            }
        }
    }
}

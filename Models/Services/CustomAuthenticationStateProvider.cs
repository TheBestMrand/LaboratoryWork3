using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using LaboratoryWork3.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

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
            var dbUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == user.Email && u.Password == user.Password);

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
            var existingUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == user.Email);

            if (existingUser == null)
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

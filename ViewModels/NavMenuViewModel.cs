using LaboratoryWork3.Models.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace LaboratoryWork3.ViewModels
{
    public class NavMenuViewModel : IDisposable
    {
        private readonly CustomAuthenticationStateProvider _authStateProvider;
        private readonly NavigationManager _navigationManager;
        public event EventHandler AuthenticationStateChanged;

        public NavMenuViewModel(CustomAuthenticationStateProvider authStateProvider, NavigationManager navigationManager)
        {
            _authStateProvider = authStateProvider;
            _navigationManager = navigationManager;
            _authStateProvider.AuthenticationStateChanged += OnAuthenticationStateChanged;
        }
        public async Task Logout()
        {
            await _authStateProvider.Logout();
            _navigationManager.NavigateTo("/");
        }

        public async Task<bool> IsAuthenticatedAsync()
        {
            return await _authStateProvider.IsAuthenticatedAsync();
        }

        public void Dispose()
        {
            _authStateProvider.AuthenticationStateChanged -= OnAuthenticationStateChanged;
        }

        private void OnAuthenticationStateChanged(Task<AuthenticationState> task)
        {
            AuthenticationStateChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}

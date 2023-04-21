using LaboratoryWork3.Models.Services;
using Microsoft.AspNetCore.Components.Authorization;

namespace LaboratoryWork3.ViewModels
{
    public class NavMenuViewModel : IDisposable
    {
        private readonly CustomAuthenticationStateProvider _authStateProvider;
        public event EventHandler AuthenticationStateChanged;

        public NavMenuViewModel(CustomAuthenticationStateProvider authStateProvider)
        {
            _authStateProvider = authStateProvider;
            _authStateProvider.AuthenticationStateChanged += OnAuthenticationStateChanged;
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

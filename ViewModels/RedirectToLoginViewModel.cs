using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;

namespace LaboratoryWork3.ViewModels
{
    public class RedirectToLoginViewModel
    {
        private readonly NavigationManager _navigationManager;
        private readonly AuthenticationStateProvider _authStateProvider;

        public RedirectToLoginViewModel(NavigationManager navigationManager, AuthenticationStateProvider authStateProvider)
        {
            _navigationManager = navigationManager;
            _authStateProvider = authStateProvider;
        }

        public async Task RedirectToLoginIfNeededAsync()
        {
            var authState = await _authStateProvider.GetAuthenticationStateAsync();
            if (!authState.User.Identity.IsAuthenticated)
            {
                _navigationManager.NavigateTo("/", true);
            }
        }
    }
}

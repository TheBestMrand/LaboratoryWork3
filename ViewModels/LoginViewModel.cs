using LaboratoryWork3.Models.Data;
using LaboratoryWork3.Models.Services;
using Microsoft.AspNetCore.Components;

namespace LaboratoryWork3.ViewModels
{
    public class LoginViewModel
    {
        private readonly CustomAuthenticationStateProvider _authenticationStateProvider;
        private readonly NavigationManager _navigationManager;

        public LoginViewModel(CustomAuthenticationStateProvider authenticationStateProvider, NavigationManager navigationManager)
        {
            _authenticationStateProvider = authenticationStateProvider;
            _navigationManager = navigationManager;
        }

        public async Task<bool> Login(User user)
        {
            var result = await _authenticationStateProvider.Login(user);
            _navigationManager.NavigateTo(_navigationManager.Uri, forceLoad: true);
            return result;
        }
    }
}

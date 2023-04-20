using System.ComponentModel;
using System.Runtime.CompilerServices;
using LaboratoryWork3.Models.Services;

namespace LaboratoryWork3.ViewModels
{
    public class UserAuthenticationViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        
        private readonly AuthenticationService _authenticationService;

        private bool _isAuthenticated;

        public bool IsAuthenticated
        {
            get => _isAuthenticated;
            set => SetField(ref _isAuthenticated, value);
        }

        public UserAuthenticationViewModel(AuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        public async Task LoginAsync(string email, string password)
        {
            var user = await _authenticationService.LoginUserAsync(email, password);
            IsAuthenticated = user != null;
        }

        public async Task SignUpAsync(string email, string password)
        {
            await _authenticationService.RegisterUserAsync(email, password);
        }
    }
}

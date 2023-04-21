using System.ComponentModel;
using System.Runtime.CompilerServices;
using LaboratoryWork3.Models.Data;

namespace LaboratoryWork3.ViewModels
{
    public class UserAuthenticationViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public User CurrentUser { get; private set; }

        private bool _isAuthenticated;

        public bool IsAuthenticated
        {
            get => _isAuthenticated;
            set => SetField(ref _isAuthenticated, value);
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

        }

        public void Logout()
        {
            CurrentUser = null;
            IsAuthenticated = false;
        }
    }
}

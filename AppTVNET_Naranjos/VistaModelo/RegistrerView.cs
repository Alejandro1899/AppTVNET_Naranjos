using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppTVNET_Naranjos.VistaModelo
{
    class RegistrerView : INotifyPropertyChanged
    {
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("RegisterEmail");
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("RegisterPassword");
            }
        }

        private string confirmPassword;
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                confirmPassword = value;
                OnPropertyChanged("ConfirmPassword");
            }
        }

        private string errorMessage;
        public string ErrorMessage
        {
            get { return errorMessage; }
            set
            {
                errorMessage = value;
                OnPropertyChanged("ErrorMessage");
            }
        }

        public ICommand RegistrerCommand { get; set; }

        public RegistrerView()
        {
            RegistrerCommand = new Command(RegistrerPage);
        }

        private void RegistrerPage()
        {
            // Aquí iría la lógica para autenticar al usuario.
            // Si el inicio de sesión es exitoso, se podría navegar a otra página de la aplicación.
            // Si hay un error de autenticación, se podría mostrar un mensaje de error en la etiqueta ErrorMessage.
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

using CursoMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppTVNET_Naranjos.VistaModelo
{
    class LoginView : BaseViewModel
    {
        #region Variables
        private string email;
        private string errorMessage;
        private string password;


        #endregion

        #region CONSTRUCTOR
        public LoginView(INavigation navigation)
        {
            Navigation = navigation;

        }

        #endregion

        #region OBJETOS
        public string Email

        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        public string ErrorMessage
        {
            get { return errorMessage; }
            set
            {
                errorMessage = value;
                OnPropertyChanged("ErrorMessage");
            }
        }

        #endregion

        public ICommand LoginCommand { get; set; }

        public LoginView()
        {
            LoginCommand = new Command(Login);
        }


        private void Login()
        {
            // Aquí iría la lógica para autenticar al usuario.
            // Si el inicio de sesión es exitoso, se podría navegar a otra página de la aplicación.
            // Si hay un error de autenticación, se podría mostrar un mensaje de error en la etiqueta ErrorMessage.
        }

    }
}

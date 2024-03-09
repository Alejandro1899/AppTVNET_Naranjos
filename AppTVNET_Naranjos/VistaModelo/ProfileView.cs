using CursoMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppTVNET_Naranjos.VistaModelo
{
    class ProfileView : BaseViewModel
    {

        #region Varialbles 
        // se declaran las variables a usar en el modelovista y/o se mandan a llanar a los objetos del modelo de la la carpeta Model
        string _Texto;
        #endregion

        #region CONSTRUCOR
        //en este se constructor se indica que la propidedad que este ViewModel tieene la propiedad de navegacion entre las vistas vistas del proyecto
        public ProfileView(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion

        #region OBJETOS
        // se crean los objetos donde se hace la manipulacion de datos
        public string Texto
        {
            get { return _Texto; }  //Retornamos la entrada de datos en estring
            set { SetValue(ref _Texto, value); } // recibimos la informaciond e String
        }
        #endregion

        #region PROCESOS
        //en estas seccio se realizan la operacio es con los objoeos que llman a los datos
        public async Task ProcesoAsyncrono()
        {
            //Las tareas Asincronas son procesoso que se ejucatan en segundo plano las cuales estan hechas para la variedad de disposoitovoas moviles y su velocidad en internet  (hablando en aplicaciones web )

            //proceso1
            await DisplayAlert("Hola", "Algo a fallado", "OK");

            //proceso2
        }
        public void ProcesoSimple()
        {

        }
        #endregion

        #region Comandos
        // los command son funciones que encapsulan los procesos y estos son llamosen las vistas.xaml
        public ICommand ProcesoAsynccommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}

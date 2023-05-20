using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CursoMVVM.ViewModel
{
    internal class ViewModelPatron : BaseViewModel
    {
        #region Varialbles 
        string _Texto;
        #endregion

        #region CONSTRUCOR
        public ViewModelPatron(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion

        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }  //Retornamos la entrada de datos en estring
            set { SetValue(ref _Texto, value); } // recibimos la informaciond e String
        }
        #endregion

        #region PROCESOS
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
        public ICommand ProcesoAsynccommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcommand => new Command( ProcesoSimple);
        #endregion

    }
}

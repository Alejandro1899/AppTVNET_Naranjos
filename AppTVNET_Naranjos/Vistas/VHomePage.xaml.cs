using System;
using AppTVNET_Naranjos.Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTVNET_Naranjos.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VHomePage : ContentPage
    {
        public List<ImgsScrolled> Imagenes {  get; set; }
        public VHomePage()
        {
            InitializeComponent();

            Imagenes = new List<ImgsScrolled>
            {
                new ImgsScrolled { Name= "Fibra Optica",Url ="https://i.ibb.co/x59jdzK/fibra-optica.jpg"},
                new ImgsScrolled { Name= "Paqutes ",Url ="https://i.ibb.co/WvLqTn0/planes-paquetes.jpg"},
                new ImgsScrolled { Name= "Conocenos",Url ="https://i.ibb.co/Ch2Wyv8/publicidad.jpg"},
                new ImgsScrolled { Name= "Ubicación",Url ="https://i.ibb.co/bvJZmRJ/ubicacion.jpg"}
            };
            this.BindingContext = this;
        }
    }
}
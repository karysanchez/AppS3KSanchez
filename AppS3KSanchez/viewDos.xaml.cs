using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppS3KSanchez
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class viewDos : ContentPage
    {
        public viewDos(string usuario, string clave)
        {
            InitializeComponent();
            //se le carga los datos para mostrar
            lblUsuario.Text = usuario;
            lblClave.Text = clave;

            txtUsuario.Text = usuario;
            txtClave.Text = clave;
        }
    }
}
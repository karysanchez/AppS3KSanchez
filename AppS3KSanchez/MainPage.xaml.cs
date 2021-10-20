using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppS3KSanchez
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //async para no consumir muchos recuros abre la una y cierra la otra y se debe usar desde ahí para cada accion el await
        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Almacenando en variables lo que el usuario ingresa
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;


                //Permite abrir la ventana  (viewDos) 
                await Navigation.PushAsync(new viewDos(usuario, clave));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de advertencia", ex.Message, "OK");
            }
        }
    }
}

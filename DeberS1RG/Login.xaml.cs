using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DeberS1RG
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login( )
        {
            InitializeComponent();
          
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Calificaciones( txtUsuario.Text, txtClave.Text));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2022";
            string clave = "esuisrael2022";

            string tUsuario = txtUsuario.Text;
            string tContrasenia = txtClave.Text;

            if (usuario == tUsuario & clave == tContrasenia)
            {
                Navigation.PushAsync(new Calificaciones(txtUsuario.Text, txtClave.Text));
            }
            else
            {
                DisplayAlert("Ops", "Usuario  no contraseña incorrectos", "OK");

            }
        }
    }
}
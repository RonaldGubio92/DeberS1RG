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
    public partial class Menu : ContentPage
    {
        public Menu(string usuario, string contrasena)
        {
            InitializeComponent();

            lblUsuario.Text = "Usuario conectado es:" + usuario;
            lblClave.Text = "" + contrasena;
        }
    }
}
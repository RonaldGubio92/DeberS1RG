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
    public partial class Calificaciones : ContentPage
    {
        public Calificaciones(string usuario, string contrasena)
        {
            InitializeComponent();

            lblUsuario.Text = "Usuario conectado es:" + usuario;
            lblClave.Text = "" + contrasena;


        }



        private void btnParcial1_Clicked(object sender, EventArgs e)
        {
          ///-------------------MOMENTO1-------------------//
          
            double SM1 = Convert.ToDouble(txtNotaSM1.Text);
            double EM1 = Convert.ToDouble(txtNotaEM1.Text);

            double seguimiento = Convert.ToDouble(0.3);
            double examen = Convert.ToDouble(0.2);

            double nSM1 = SM1 * seguimiento;
            double nEM1 = EM1 * examen;

            double nota_momento1 = nSM1 + nEM1;
            txtResultadoM1.Text = nota_momento1.ToString();


            ///-------------------MOMENTO2-------------------//
            double SM2 = Convert.ToDouble(txtNotaSM2.Text);
            double EM2 = Convert.ToDouble(txtNotaEM2.Text);
            
            double nSM2 = SM2 * seguimiento;
            double nEM2 = EM2 * examen;

            double nota_momento2 = nSM2 + nEM2;           

            txtResultadoM2.Text = nota_momento2.ToString();


            double nota_final = nota_momento2 + nota_momento1;
            txtResultadoFinal.Text = nota_final.ToString();

            if (nota_final >= 7)
            {
                DisplayAlert("Alerta", "Aprueba con :" + nota_final, "Cerrar");
            }
            else if (nota_final >= 5 && nota_final < 7)
            {
                DisplayAlert("Alerta", "Complementario con :" + nota_final, "Cerrar");
            }
            else
            {
                DisplayAlert("Alerta", "Reprueba con :" + nota_final, "Cerrar");
            }


          //  if (nota_final >= 6)
          //  {
          //     DisplayAlert("Alerta","Aprueba con :" + nota_final, "OK");
          //  }
          //  else
          //  {
          //  DisplayAlert("Ops", "Reprueba con :" + nota_final, "OK");
          //  }
        }

        private void txtNotaSM2_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry ent = (sender as Entry);
            if (!String.IsNullOrEmpty(ent.Text))
            {
                int valor = Convert.ToInt32(ent.Text);

                if (valor < 1 || valor > 10)
                {
                    DisplayAlert("Alerta", "El valor es mayor al permitido", "Cerrar");
                    ent.Focus();
                    ent.Text = String.Empty;
                }
            }
        }

        private void txtNotaEM2_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry ent = (sender as Entry);
            if (!String.IsNullOrEmpty(ent.Text))
            {
                int valor = Convert.ToInt32(ent.Text);

                if (valor < 1 || valor > 10)
                {
                    DisplayAlert("Alerta", "El valor es mayor al permitido", "Cerrar");
                    ent.Focus();
                    ent.Text = String.Empty;
                }
            }
        }

        private void txtNotaSM1_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry ent = (sender as Entry);
            if (!String.IsNullOrEmpty(ent.Text))
            {
                int valor = Convert.ToInt32(ent.Text);

                if (valor < 1 || valor > 10)
                {
                    DisplayAlert("Alerta", "El valor es mayor al permitido", "Cerrar");
                    ent.Focus();
                    ent.Text = String.Empty;
                }
            }
        }

        private void txtNotaEM1_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry ent = (sender as Entry);
            if (!String.IsNullOrEmpty(ent.Text))
            {
                int valor = Convert.ToInt32(ent.Text);

                if (valor < 1 || valor > 10)
                {
                    DisplayAlert("Alerta", "El valor es mayor al permitido", "Cerrar");
                    ent.Focus();
                    ent.Text = String.Empty;
                }
            }
        }

        private  void btnMenu_Clicked(object sender, EventArgs e)
        {
           

        }
    }
}
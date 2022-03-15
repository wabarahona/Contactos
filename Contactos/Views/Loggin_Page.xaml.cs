using System;
using Contactos.Views;
using System.Collections.Generic;
using Xamarin.Forms;



namespace Contactos.Views
{
    public partial class Loggin_Page : ContentPage
    {
        public Loggin_Page()
        {
            InitializeComponent();
        }

        private  void Button_Clicked(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "abarahona" && TxtPassword.Text == "admin")
            {
                Navigation.PushAsync(new PageAdmin());
            }

            else if (TxtUsername.Text == "abarahona" && TxtPassword.Text == "usuario")
            {
                Navigation.PushAsync(new PageUsuarios());
            }
            
           else
            {
                DisplayAlert("Opps", "Verificar Usuario y Contraseña", "intente nuevamente");
            }


        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}

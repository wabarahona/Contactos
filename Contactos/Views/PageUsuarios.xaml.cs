using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Contactos.Views
{
    public partial class PageUsuarios : ContentPage
    {
        public PageUsuarios()
        {
            InitializeComponent();
        }

         void btnVer_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RegistrarPersonas());
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RegistrarPersonas());

        }
    }
}

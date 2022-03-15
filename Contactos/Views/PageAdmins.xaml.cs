using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Contactos.Views
{
    public partial class PageAdmin : ContentPage
    {
        public PageAdmin()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CrearRegistro());
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ActualizarRegistro());
        }

        void Button_Clicked_2(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BorrarRegistro());
        }
    }
}

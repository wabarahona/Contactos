using System;
using Contactos.Models;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Contactos.Views
{
    public partial class CrearRegistro : ContentPage
    {
        public CrearRegistro()
        {
            InitializeComponent();
        }


        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var persona = new RegistroPersonas
            {
                Nombre = Nombre.Text,
                Apellido = Apellido.Text,
                Edad = Edad.Text,
               // Pais = Picker.SelectedItemProperty.ToString(),
              //  Nota = Nota.Text,
               




            };

        }

        void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
        }
        // async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        //{
        //  var Posicion = await Geolocation.GetLocationAsync(new GeolocationRequest
        //   (GeolocationAccuracy.Best, TimeSpan.FromMinutes(1)));
        // }

        // async void ClickGestureRecognizer_Clicked(System.Object sender, System.EventArgs e)
        // {
        //    var Posicion = await Geolocation.GetLocationAsync(new GeolocationRequest
        //       (GeolocationAccuracy.Best, TimeSpan.FromMinutes(1)));


        // }



    }
}

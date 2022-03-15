using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace Contactos.Views
{
    public partial class Registros : ContentPage
    {
        public Registros()
        {
            InitializeComponent();
        }

        void ListaRegistros_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            ListaRegistros.ItemsSource = await App.InitbBase.GetRegistroPersonas(ListaRegistros);
        }
    }
}

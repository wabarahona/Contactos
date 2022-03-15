using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Contactos.Views;
using System.IO;
using Contactos.Controllers;

namespace Contactos
{
    public partial class App : Application
    {


        static RegDBase dBase;

        public static RegDBase InitbBase
        {
            get
            {
                if (dBase == null)
                {
                    dBase = new RegDBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "dBase.db3"));
                }
                return dBase;


            }

            set
            {

            }
        }
 


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Loggin_Page());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kavyas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashScreen : ContentPage
    {
        public SplashScreen()
        {
            InitializeComponent();
            Task.Delay(5000);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            App.Current.MainPage = new LoginPage();
        }
    }
}
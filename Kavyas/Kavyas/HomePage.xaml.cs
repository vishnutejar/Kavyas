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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            lstKavyas.ItemsSource = GetKavyas();
        }

        public List<KavyasModel> GetKavyas() {

            var lstDat = new List<KavyasModel>() 
            {
                new KavyasModel() { Title="T1",TitleDiscription="d1" },
                new KavyasModel() { Title="T1" },
                new KavyasModel() { Title="T1" },
                new KavyasModel() { Title="T1" },
                new KavyasModel() { Title="T1" }
            };

            return lstDat;

        }
    }
}
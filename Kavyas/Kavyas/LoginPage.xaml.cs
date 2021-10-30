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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginValidation(object sender, EventArgs e)
        {
            //string email, passwrd;
            //email = entEmail.Text;
            //passwrd = entPassword.Text;
            //if (IsUserValid(email, passwrd)) {

            //    DisplayAlert("You have entered following Email" +email,"You have entered following password" +passwrd,"ok");
            //}
            Navigation.PushAsync(new HomePage());
        }

        private bool IsUserValid(string Email,string Password) {

            if (string.IsNullOrEmpty(Email))
            {

                DisplayAlert("title: Email", "Enter Your Email", "ok");
                return false;
            }
            else if (string.IsNullOrEmpty(Password))
            {
                DisplayAlert("title: Password", "Enter Your password", "ok");
                return false;
            }
            else {

                return true;
            }
        }
    }
}
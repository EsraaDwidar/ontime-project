using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnTime3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Loginpage : ContentPage
    {
        public Loginpage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(txtUsername.Text == "DrAmr@gmail.com" && txtPassword.Text == "1234")
            {
                Navigation.PushAsync(new MyflyoutPage());
            }
            else
            {
                DisplayAlert("Ops..😭", "Username or Password is incorrect!", "Ok");

            }
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());

        }
    }
}
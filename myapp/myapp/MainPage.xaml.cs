using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Authgear.Xamarin;

namespace myapp
{
    public partial class MainPage : ContentPage
    {
        private AuthgearSdk authgear;

        public MainPage()
        {
            InitializeComponent();
            authgear = DependencyService.Get<AuthgearSdk>();
        }

        async void Configure_Clicked(object sender, EventArgs e)
        {
            // You must configure the instance before use.
            // Typically you should do this once on app launch.
            await authgear.ConfigureAsync();
        }

        async void Authenticate_Clicked(object sender, EventArgs e)
        {
            var userInfo = await authgear.AuthenticateAsync(new AuthenticateOptions
            {
                RedirectUri = "com.myapp.example://host/path"
            });
        }
    }
}

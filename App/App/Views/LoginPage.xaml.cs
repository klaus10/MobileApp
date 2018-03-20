using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentView
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        void Signin_Clicked(Object sender, EventArgs e)
        {
            User user = new User(entry_Username.Text, entry_Password.Text);
            if (user.CheckInfo())
            {
                DisplayAlert("Login", "Login Success", "Ok");
            }
            else
            {
                DisplayAlert("Login", "Login Not Correct!", "Ok");
            }
        }

        x
	}
}
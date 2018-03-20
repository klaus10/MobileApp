using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace App.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://nanuku.aubergeresorts.com/residences/")));
        }

        public ICommand OpenWebCommand { get; }
    }
}
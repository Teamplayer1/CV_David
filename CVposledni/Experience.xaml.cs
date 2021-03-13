using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace CVposledni
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Experience : ContentPage
    {
        public Experience()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
           await Browser.OpenAsync("https://starty.cz/author/david-hanc/", BrowserLaunchMode.SystemPreferred);
        }
    }
}
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
    public partial class End : ContentPage
    {
        public End()
        {
            InitializeComponent();
            
        }

        string lat = "50.07794178082049";
        string lon = "14.426502340895745";
        string address = "Ve Smečkách 7, 110 00 Nové Město Praha";

        private async void Cesta_Clicked(object sender, EventArgs e)

        {
            

            var location = new Location(50.071021063561105, 14.448941280438818);
            var options = new MapLaunchOptions { NavigationMode = NavigationMode.None, 
                                                  Name ="Budoucí práce"};

            try
            {
                await Map.OpenAsync(location, options);
            }
            catch (Exception ex)
            {
                // No map application available to open
            }
            
            
            // await Map.OpenAsync(50.07794178082049, 14.426502340895745, new MapLaunchOptions { NavigationMode = NavigationMode.None });
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var message = new EmailMessage(Subject.Text, "Dobrý den, tímto emailem Vás chceme informovat, že jste byl přijat. &#10; S pozdravem... ", Email.Text);
            
            await Xamarin.Essentials.Email.ComposeAsync(message);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                await Xamarin.Essentials.Sms.ComposeAsync(new SmsMessage(Sms.Text, Phonenumber.Text));
            }
            catch
            {
                throw;
            }
            //{Body=Sms.Text, Recipients = new List<string> { Phonenumber.Text } }
        }

        //  protected async override void OnAppearing()   pokud chci něco udělat při načtení stránky
        // {
        //   base.OnAppearing(); } 

        // 50.07794178082049, 14.426502340895745
        // await Map.OpenAsync(50.07794178082049, 14.426502340895745, new MapLaunchOptions { NavigationMode = NavigationMode.Transit });            




    }
}
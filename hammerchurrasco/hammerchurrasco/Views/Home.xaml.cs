using hammerchurrasco.Models;
using hammerchurrasco.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace hammerchurrasco
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        private readonly int _idEmployee;
        public Home(int id)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            _idEmployee = id;
        }

        private async void tapDetails_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateParticipant());
        }

        private async void btnConsult_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Participants(_idEmployee));
        }

        private async void btnCadastro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateParticipant());
        }
    }
}

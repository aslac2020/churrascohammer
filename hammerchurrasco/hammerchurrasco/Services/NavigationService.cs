using hammerchurrasco.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace hammerchurrasco.Services
{
   public  class NavigationService : INavigationService
    {
        public async Task NavigateToParticipant()
        {
            await hammerchurrasco.App.Current.MainPage.Navigation.PushAsync(new CreateParticipant());
        }
        public async Task NavigateToDetailsParticipant(int Id)
        {
            await hammerchurrasco.App.Current.MainPage.Navigation.PushAsync(new BarbecueDetails(Id));
        }
        public async Task NavigateToListParticipant()
        {
            await hammerchurrasco.App.Current.MainPage.Navigation.PushAsync(new CreateParticipant());
        }
        public async void PopAsyncService()
        {
            await hammerchurrasco.App.Current.MainPage.Navigation.PopAsync();
        }
    }
}

using hammerchurrasco.Services;
using hammerchurrasco.Views;
using Xamarin.Forms;

namespace hammerchurrasco
{
    public partial class App : Application
    {
        IBarbecueRepository _barbecueRepository;
        private readonly int _idEmployee;
        
        public App()
        {
            InitializeComponent();

            DependencyService.Register<INavigationService, NavigationService>();
            _barbecueRepository = new BarbecueRepository();
            OnAppStart();

            MainPage = new NavigationPage(new Home(_idEmployee));
        }

        private void OnAppStart()
        {
            //obtem todos os dados 
            var getLocalDB = _barbecueRepository.GetParticipants();
            //se existir dados então exibe a lista senão inclui dados
            if (getLocalDB.Count > 0)
            {
                MainPage = new NavigationPage(new Home(_idEmployee));
            }
            else
            {
                MainPage = new NavigationPage(new CreateParticipant());
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

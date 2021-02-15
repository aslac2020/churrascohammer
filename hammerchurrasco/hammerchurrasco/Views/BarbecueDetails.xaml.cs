using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace hammerchurrasco.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarbecueDetails : ContentPage
    {
        public BarbecueDetails(int Id)
        {
            InitializeComponent();
        }

    }
}
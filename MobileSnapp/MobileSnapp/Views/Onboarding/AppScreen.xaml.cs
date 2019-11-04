using MobileSnapp.ViewModels.Onboarding;
using Xamarin.Forms;

namespace MobileSnapp.Views.Onboarding
{
    public partial class AppScreen : ContentPage
    {
        private AppScreenViewModel _viewModel;

        public AppScreen()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_viewModel == null)
            {
                _viewModel = new AppScreenViewModel();
                BindingContext = _viewModel;
            }
        }
    }
}

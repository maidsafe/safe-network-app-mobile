using MobileSnapp.ViewModels.Onboarding;
using Xamarin.Forms;

namespace MobileSnapp.Views.OnBoarding
{
    public partial class CreateAccountOptionsPage : ContentPage
    {
        private CreateAccountOptionsViewModel _viewModel;

        public CreateAccountOptionsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_viewModel == null)
            {
                _viewModel = new CreateAccountOptionsViewModel(Navigation);
                BindingContext = _viewModel;
            }
        }
    }
}

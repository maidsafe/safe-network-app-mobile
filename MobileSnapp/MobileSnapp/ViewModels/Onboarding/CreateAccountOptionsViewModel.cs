using System.Collections.ObjectModel;
using MobileSnapp.Helpers;
using MobileSnapp.Models.Onboarding;
using MvvmHelpers;
using Xamarin.Forms;

namespace MobileSnapp.ViewModels.Onboarding
{
    public class CreateAccountOptionsViewModel : BaseViewModel
    {
        private const string _staticContentFile = "CreateAccountOnboarding.json";

        private INavigation _navigation;

        private ObservableCollection<CreateAccountOnboardingItemWithDesktopOption> _createAccountOptions;

        public CreateAccountOptionsViewModel(INavigation navigation)
        {
            _navigation = navigation;
            CreateAccountOptions = new ObservableCollection<CreateAccountOnboardingItemWithDesktopOption>(
                ContentHelpers.PopulateData<CreateAccountOnboardingStaticContent>(
                    _staticContentFile)
                .CreateAccountOptionList);
        }

        public ObservableCollection<CreateAccountOnboardingItemWithDesktopOption> CreateAccountOptions
        {
            get => _createAccountOptions;
            set => SetProperty(ref _createAccountOptions, value);
        }
    }
}

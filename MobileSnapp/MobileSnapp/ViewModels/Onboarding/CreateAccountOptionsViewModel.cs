// Copyright 2019 MaidSafe.net limited.
//
// This SAFE Network Software is licensed to you under the MIT license <LICENSE-MIT
// https://opensource.org/licenses/MIT> or the Modified BSD license <LICENSE-BSD
// https://opensource.org/licenses/BSD-3-Clause>, at your option. This file may not be copied,
// modified, or distributed except according to those terms. Please review the Licences for the
// specific language governing permissions and limitations relating to use of the SAFE Network
// Software.

using System.Collections.ObjectModel;
using System.Windows.Input;
using MobileSnapp.Helpers;
using MobileSnapp.Models.Onboarding;
using MobileSnapp.ViewModels.Common;
using MobileSnapp.Views.Onboarding;
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
            RedeemInviteCommand = new Command(() =>
            {
                _navigation.PopModalAsync();
                _navigation.PushModalAsync(new NavigationPage(new CreateAccountPage()));
            });
        }

        public ObservableCollection<CreateAccountOnboardingItemWithDesktopOption> CreateAccountOptions
        {
            get => _createAccountOptions;
            set => SetProperty(ref _createAccountOptions, value);
        }

        public ICommand RedeemInviteCommand { get; }
    }
}

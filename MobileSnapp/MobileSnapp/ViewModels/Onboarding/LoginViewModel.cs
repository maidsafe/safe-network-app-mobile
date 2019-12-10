// Copyright 2019 MaidSafe.net limited.
//
// This SAFE Network Software is licensed to you under the MIT license <LICENSE-MIT
// https://opensource.org/licenses/MIT> or the Modified BSD license <LICENSE-BSD
// https://opensource.org/licenses/BSD-3-Clause>, at your option. This file may not be copied,
// modified, or distributed except according to those terms. Please review the Licences for the
// specific language governing permissions and limitations relating to use of the SAFE Network
// Software.

using System.Windows.Input;
using MobileSnapp.ViewModels.Common;
using MobileSnapp.Views.Onboarding;
using Xamarin.Forms;

namespace MobileSnapp.ViewModels.Onboarding
{
    public class LoginViewModel : BaseViewModel
    {
        private INavigation _navigation;

        public ICommand CreateAccountCommand { get; }

        public ICommand BackCommand { get; }

        public LoginViewModel(INavigation navigation)
        {
            _navigation = navigation;

            CreateAccountCommand = new Command(() =>
            {
                _navigation.PopModalAsync();
                _navigation.PushModalAsync(new NavigationPage(new CreateAccountOnboardingPage()));
            });

            BackCommand = new Command(() => _navigation.PopModalAsync());
        }
    }
}

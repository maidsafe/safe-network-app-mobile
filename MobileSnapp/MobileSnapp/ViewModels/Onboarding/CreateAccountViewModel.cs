// Copyright 2019 MaidSafe.net limited.
//
// This SAFE Network Software is licensed to you under the MIT license <LICENSE-MIT
// https://opensource.org/licenses/MIT> or the Modified BSD license <LICENSE-BSD
// https://opensource.org/licenses/BSD-3-Clause>, at your option. This file may not be copied,
// modified, or distributed except according to those terms. Please review the Licences for the
// specific language governing permissions and limitations relating to use of the SAFE Network
// Software.

using System.Collections.Generic;
using System.Windows.Input;
using MobileSnapp.ViewModels.Common;
using MobileSnapp.Views.Onboarding;
using Xamarin.Forms;

namespace MobileSnapp.ViewModels.Onboarding
{
    public class CreateAccountViewModel : BaseViewModel
    {
        private INavigation _navigation;

        public List<string> AccountCreationWizardSteps { get; } = new List<string>
        {
            "Invite",
            "Password",
            "PassPhrase"
        };

        private int _createAccountWizardCurrentStep;

        public int CreateAccountWizardCurrentStep
        {
            get => _createAccountWizardCurrentStep;
            set => SetProperty(ref _createAccountWizardCurrentStep, value);
        }

        public ICommand NextOrCreateAccountCommand { get; }

        public ICommand BackCommand { get; }

        public ICommand ModelPopUpCommand { get; }

        public CreateAccountViewModel(INavigation navigation)
        {
            _navigation = navigation;

            BackCommand = new Command(
                () => CreateAccountWizardCurrentStep -= 1,
                () => CreateAccountWizardCurrentStep > 0);

            NextOrCreateAccountCommand = new Command(
                () =>
                {
                    if (CreateAccountWizardCurrentStep == 2)
                        _navigation.PushAsync(new AccountCreatedSuccessFully());
                    else
                        CreateAccountWizardCurrentStep += 1;
                },
                () => CreateAccountWizardCurrentStep <= 2);

            ModelPopUpCommand = new Command(() => _navigation.PopModalAsync());
        }
    }
}

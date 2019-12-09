// Copyright 2019 MaidSafe.net limited.
//
// This SAFE Network Software is licensed to you under the MIT license <LICENSE-MIT
// https://opensource.org/licenses/MIT> or the Modified BSD license <LICENSE-BSD
// https://opensource.org/licenses/BSD-3-Clause>, at your option. This file may not be copied,
// modified, or distributed except according to those terms. Please review the Licences for the
// specific language governing permissions and limitations relating to use of the SAFE Network
// Software.

using MobileSnapp.ViewModels.Onboarding;
using Xamarin.Forms;

namespace MobileSnapp.Views.Onboarding
{
    public partial class CreateAccountPage : ContentPage
    {
        private CreateAccountViewModel _viewModel;

        public CreateAccountPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_viewModel == null)
            {
                _viewModel = new CreateAccountViewModel(Navigation);
                BindingContext = _viewModel;
            }
        }
    }
}

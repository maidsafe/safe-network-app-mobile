using System;
using System.Collections.Generic;
using MobileSnapp.ViewModels.Common;
using Xamarin.Forms;

namespace MobileSnapp.Views.Common
{
    public partial class SettingsPage : ContentPage
    {
        private SettingsViewModel _viewModel;

        public SettingsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_viewModel == null)
            {
                _viewModel = new SettingsViewModel(Navigation);
                BindingContext = _viewModel;
            }
        }
    }
}

using System.Collections.ObjectModel;
using System.Windows.Input;
using MobileSnapp.Helpers;
using MobileSnapp.Models.Onboarding;
using MvvmHelpers;
using Xamarin.Forms;

namespace MobileSnapp.ViewModels.Onboarding
{
    public class AppScreenViewModel : BaseViewModel
    {
        #region Fields

        private bool _isAppAvailable;

        #endregion

        #region Constructor

        public AppScreenViewModel()
        {
            IsAppAvailable = false;
        }

        #endregion

        #region Commands

        #endregion

        #region Properties

        public bool IsAppAvailable
        {
            get { return _isAppAvailable; }
            set { _isAppAvailable = value; }
        }

        #endregion
    }
}

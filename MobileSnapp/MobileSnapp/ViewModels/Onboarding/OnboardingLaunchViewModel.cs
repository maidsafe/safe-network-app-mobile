using System.Collections.ObjectModel;
using System.Windows.Input;
using MobileSnapp.Helpers;
using MobileSnapp.Models.Onboarding;
using MvvmHelpers;
using Xamarin.Forms;

namespace MobileSnapp.ViewModels.Onboarding
{
    /// <summary>
    /// ViewModel for on-boarding gradient page.
    /// </summary>
    public class OnBoardingLaunchViewModel : BaseViewModel
    {
        #region Fields

        private const string _staticContentFile = "OnboardingLaunch.json";

        private ObservableCollection<CarouselItem> boardings;

        private string nextButtonText = "NEXT";

        private int selectedIndex;

        #endregion

        #region Constructor

        public OnBoardingLaunchViewModel()
        {
            OnBoardingLaunchItems = new ObservableCollection<CarouselItem>(
               ContentHelpers.PopulateData<OnboardingLaunch>(
                   _staticContentFile)
               .CarouselItems);

            BackCommand = new Command(Back);
            NextCommand = new Command(Next);
        }

        #endregion

        #region Commands

        /// <summary>
        /// Gets or sets the command that is executed when the Back button is clicked.
        /// </summary>
        public ICommand BackCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the Done button is clicked.
        /// </summary>
        public ICommand NextCommand { get; set; }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the boardings collection.
        /// </summary>
        public ObservableCollection<CarouselItem> OnBoardingLaunchItems
        {
            get => boardings;
            set => SetProperty(ref boardings, value);
        }

        public string NextButtonText
        {
            get => nextButtonText;
            set
            {
                if (nextButtonText == value)
                {
                    return;
                }
                nextButtonText = value;
                OnPropertyChanged();
            }
        }

        public int SelectedIndex
        {
            get => selectedIndex;
            set
            {
                if (selectedIndex == value)
                {
                    return;
                }
                SetProperty(ref selectedIndex, value);

                ValidateSelection();
            }
        }

        #endregion

        #region Methods

        private void ValidateSelection()
        {
            NextButtonText = selectedIndex < OnBoardingLaunchItems.Count - 1 ? "NEXT" : "DONE";
        }

        /// <summary>
        /// Invoked when the Done button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void Next(object obj)
        {
            if (ValidateAndUpdateSelectedIndex())
            {
                Application.Current.MainPage.Navigation.PopAsync();
            }
        }

        /// <summary>
        /// Invoked when the Done button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void Back(object obj)
        {
            if (ValidateAndUpdateSelectedIndex(true))
            {
                Application.Current.MainPage.Navigation.PopAsync();
            }
        }

        private bool ValidateAndUpdateSelectedIndex(bool back = false)
        {
            if (back)
            {
                if (selectedIndex == 0)
                    return true;

                SelectedIndex--;
                return false;
            }

            if (selectedIndex >= OnBoardingLaunchItems.Count - 1)
                return true;

            SelectedIndex++;
            return false;
        }

        #endregion
    }
}

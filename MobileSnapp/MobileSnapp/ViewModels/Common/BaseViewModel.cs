using MobileSnapp.Services;
using Xamarin.Forms;

namespace MobileSnapp.ViewModels.Common
{
    public class BaseViewModel : MvvmHelpers.BaseViewModel
    {
        public IPlatformService PlatformService =>
            DependencyService.Get<IPlatformService>();
    }
}

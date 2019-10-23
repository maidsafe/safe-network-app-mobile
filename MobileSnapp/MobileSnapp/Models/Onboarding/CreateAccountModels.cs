using System.Collections.Generic;

namespace MobileSnapp.Models.Onboarding
{
    public class CreateAccountOnboardingStaticContent
    {
        public List<CreateAccountOnboardingItem> CreateAccountOnboarding { get; set; }

        public List<CreateAccountOnboardingItem> CreateAccountOptionList { get; set; }
    }

    public class CreateAccountOnboardingItem
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Image { get; set; }

        public bool? IsDesktopOnly { get; set; }
    }
}

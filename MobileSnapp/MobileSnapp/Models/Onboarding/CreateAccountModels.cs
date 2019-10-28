using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MobileSnapp.Models.Onboarding
{
    [DataContract]
    public class CreateAccountOnboardingStaticContent
    {
        [DataMember(Name = "createAccountOnboarding")]
        public List<CreateAccountOnboardingItem> CreateAccountOnboarding { get; set; }

        [DataMember(Name = "createAccountOptionList")]
        public List<CreateAccountOnboardingItemWithDesktopOption> CreateAccountOptionList { get; set; }
    }

    [DataContract]
    public class CreateAccountOnboardingItemWithDesktopOption
    {
        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "content")]
        public string Content { get; set; }

        [DataMember(Name = "image")]
        public string Image { get; set; }

        [DataMember(Name = "isDesktopOnly")]
        public bool IsDesktopOnly { get; set; }
    }

    [DataContract]
    public class CreateAccountOnboardingItem
    {
        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "content")]
        public string Content { get; set; }

        [DataMember(Name = "image")]
        public string Image { get; set; }
    }
}

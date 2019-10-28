using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MobileSnapp.Models.Onboarding
{
    [DataContract]
    public class OnboardingLaunch
    {
        [DataMember(Name = "carouselHeader")]
        public string CarouselHeader { get; set; }

        [DataMember(Name = "carouselItems")]
        public List<CarouselItem> CarouselItems { get; set; }

        [DataMember(Name = "bottomLayoutSecondaryTitle")]
        public string BottomLayoutSecondaryTitle { get; set; }

        [DataMember(Name = "bottomLayoutPrimaryTitle")]
        public string BottomLayoutPrimaryTitle { get; set; }
    }

    [DataContract]
    public class CarouselItem
    {
        [DataMember(Name = "content")]
        public string Content { get; set; }

        [DataMember(Name = "isVisible")]
        public bool IsVisible { get; set; }

        [DataMember(Name = "primaryTitle")]
        public string PrimaryTitle { get; set; }

        [DataMember(Name = "secondaryTitle")]
        public string SecondaryTitle { get; set; }

        [DataMember(Name = "color")]
        public string Color { get; set; }
    }
}

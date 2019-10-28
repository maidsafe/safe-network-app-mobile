// Copyright 2019 MaidSafe.net limited.
//
// This SAFE Network Software is licensed to you under the MIT license <LICENSE-MIT
// https://opensource.org/licenses/MIT> or the Modified BSD license <LICENSE-BSD
// https://opensource.org/licenses/BSD-3-Clause>, at your option. This file may not be copied,
// modified, or distributed except according to those terms. Please review the Licences for the
// specific language governing permissions and limitations relating to use of the SAFE Network
// Software.
﻿using System.Collections.Generic;
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

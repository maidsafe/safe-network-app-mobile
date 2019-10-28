// Copyright 2019 MaidSafe.net limited.
//
// This SAFE Network Software is licensed to you under the MIT license <LICENSE-MIT
// https://opensource.org/licenses/MIT> or the Modified BSD license <LICENSE-BSD
// https://opensource.org/licenses/BSD-3-Clause>, at your option. This file may not be copied,
// modified, or distributed except according to those terms. Please review the Licences for the
// specific language governing permissions and limitations relating to use of the SAFE Network
// Software.

using System.Collections.Generic;
﻿using System.Collections.Generic;
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

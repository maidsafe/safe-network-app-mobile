using MobileSnapp.Models.Onboarding;
using Xamarin.Forms;

namespace MobileSnapp.Views.TemplateSelectors
{
    public class CreateAccountWizardTemplateSelector : DataTemplateSelector
    {
        public DataTemplate EnterInviteTemplate { get; set; }

        public DataTemplate ChoosePasswordTemplate { get; set; }

        public DataTemplate ChoosePassPhaseTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            switch ((string)item)
            {
                case "Invite":
                    return EnterInviteTemplate;
                case "Password":
                    return ChoosePasswordTemplate;
                case "PassPhase":
                    return ChoosePassPhaseTemplate;
            }

            return EnterInviteTemplate;
        }
    }
}

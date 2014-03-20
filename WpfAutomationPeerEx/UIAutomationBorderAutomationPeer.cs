using System.Collections.Generic;
using System.Windows.Automation.Peers;
using System.Windows.Controls;

namespace WpfAutomationPeerEx
{
    public class UIAutomationBorderAutomationPeer : FrameworkElementAutomationPeer
    {
        public UIAutomationBorderAutomationPeer(Border owner) : base(owner)
        {
        }

        protected override List<AutomationPeer> GetChildrenCore()
        {
            var childrenAutomationPeer = new List<AutomationPeer>();
            var owner = Owner as Border;

            if (owner != null)
            {
                var buttonTextBlock = owner.FindName("ButtonContent") as TextBlock;
                if (buttonTextBlock != null)
                {
                    var textBlockAutomationPeer = new CustomTextBlockAutomationPeer(buttonTextBlock);
                    childrenAutomationPeer.Add(textBlockAutomationPeer);
                }
            }

            return childrenAutomationPeer;
        }
    }
}
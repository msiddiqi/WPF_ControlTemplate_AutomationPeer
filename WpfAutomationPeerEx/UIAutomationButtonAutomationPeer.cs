using System.Collections.Generic;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace WpfAutomationPeerEx
{
    public class UIAutomationButtonAutomationPeer : ButtonAutomationPeer
    {
        public UIAutomationButtonAutomationPeer(UIAutomationButton owner) : base(owner)
        {}

        protected override List<AutomationPeer> GetChildrenCore()
        {
            var childrenAutomationPeer = new List<AutomationPeer>();

            var owner = Owner as UIAutomationButton;

            if (owner != null)
            {
                var surroundingEllispe = owner.Template.FindName("ButtonSurroundingEllipsis", owner) as Ellipse;
                if (surroundingEllispe != null)
                {
                    var headerTextBlockAutomationPeer = new FrameworkElementAutomationPeer(surroundingEllispe);
                    childrenAutomationPeer.Add(headerTextBlockAutomationPeer);
                }

                var textSurroundingBorder = owner.Template.FindName("TextSurroundingBorder", owner) as Border;
                if (textSurroundingBorder != null)
                {
                    var matchListBoxAutomationPeer = new UIAutomationBorderAutomationPeer(textSurroundingBorder);
                    childrenAutomationPeer.Add(matchListBoxAutomationPeer);
                }

                var copyrightTextBlock = owner.Template.FindName("CopyrightLabel", owner) as TextBlock;
                if (copyrightTextBlock != null)
                {
                    var textBlockAutomationPeer = new CustomTextBlockAutomationPeer(copyrightTextBlock);
                    childrenAutomationPeer.Add(textBlockAutomationPeer);
                }
            }

            return childrenAutomationPeer;
        }
    }
}

using System.Windows.Automation.Peers;
using System.Windows.Controls;

namespace WpfAutomationPeerEx
{
    public class CustomTextBlockAutomationPeer : TextBlockAutomationPeer
    {
        public CustomTextBlockAutomationPeer(TextBlock owner) : base(owner)
        {   
        }

        protected override bool IsControlElementCore()
        {
            return true;
        }
    }
}
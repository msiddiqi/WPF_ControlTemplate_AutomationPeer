﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;
using System.Windows.Controls;

namespace WpfAutomationPeerEx
{
    public class UIAutomationButton : Button
    {
        protected override AutomationPeer OnCreateAutomationPeer()
        {
            return new UIAutomationButtonAutomationPeer(this);
        }
    }
}

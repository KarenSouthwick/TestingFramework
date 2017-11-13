using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformAutomation1
{
    public class DashboardPage
    {
        public static bool IsAt

        {
            get
            {
                var bs = Driver.Instance.FindElements(By.TagName("b"));
                if (bs.Count > 0)
                    return bs[0].Text == "Karen Southwick";
                return false;
            }
        }
    }
}

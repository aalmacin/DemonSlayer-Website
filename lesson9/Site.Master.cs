using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lesson9
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //disable admin link if needed
            if (HttpContext.Current.User.IsInRole("Admin"))
            {
                NavigationMenu.Items[1].Enabled = true;
            }
            else
            {
                NavigationMenu.Items[1].Enabled = false;
            }

            if (HttpContext.Current.User.IsInRole("User"))
            {
                NavigationMenu.Items[2].Enabled = true;
            }
            else
            {
                NavigationMenu.Items[2].Enabled = false;
            }
        }
    }
}

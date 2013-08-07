using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemonSlayer
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NavigationMenu.Items[1].Enabled = false;
            NavigationMenu.Items[2].Enabled = false;

            // Enable links for admins to be accessible by admins.
            if (HttpContext.Current.User.IsInRole("Admin"))
            {
                NavigationMenu.Items[1].Enabled = true;
                NavigationMenu.Items[2].Enabled = true;
            }

            // Enable links for user to be accessible by user.
            if (HttpContext.Current.User.IsInRole("User"))
            {
                NavigationMenu.Items[2].Enabled = true;
            }
            
        }
    }
}

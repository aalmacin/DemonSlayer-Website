using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemonSlayer.Admin
{
    public partial class EditHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPost_Click(object sender, EventArgs e)
        {
          BusinessRules.CPost objPost = new BusinessRules.CPost();
          objPost.Post = txtPost.Text;
          objPost.UserID = BusinessRules.CUser.getIDByName(HttpContext.Current.User.Identity.Name);
          objPost.save();
          Response.Redirect("/home.aspx", true);
        }
    }
}
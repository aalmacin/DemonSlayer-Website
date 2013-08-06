using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemonSlayer
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //create an instance of our business class
            BusinessRules.CUser objUser = new BusinessRules.CUser();

            //call the register function and redirect the user
            objUser.register(txtUsername.Text, txtPassword.Text, rblRole.SelectedValue);
            Response.Redirect("login.aspx", true);
        }
    }
}
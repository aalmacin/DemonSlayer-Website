using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace DemonSlayer
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            BusinessRules.CUser objUser = new BusinessRules.CUser();
            string role;

            role = objUser.login(txtUsername.Text, txtPassword.Text);

            if (role == "")
            {
                lblError.Text = "Invalid Login";
            }
            else
            {
                //create an auth ticket to store the identity
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                    1,
                    txtUsername.Text,
                    DateTime.Now,
                    DateTime.Now.AddMinutes(30),
                    true,
                    role,
                    FormsAuthentication.FormsCookiePath);

                //encrypt the ticket for extra security
                string hash = FormsAuthentication.Encrypt(ticket);
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hash);

                Response.Cookies.Add(cookie);
                Response.Redirect("home.aspx", true);

            }
        
        }
    }
}
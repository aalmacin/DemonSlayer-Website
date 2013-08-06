using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Security.Principal;

namespace DemonSlayer
{
    public class Global : System.Web.HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup

        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
             //user = HttpContext.Current.User;
             if (HttpContext.Current.User == null || !HttpContext.Current.User.Identity.IsAuthenticated)
             {
                 return;
             }

            //get the current user identify
             var fi = (FormsIdentity)HttpContext.Current.User.Identity;

            //access the authentication ticket
             var fa = fi.Ticket;

            //parse the ticket to see what role(s) the user is in
             var astrRoles = fa.UserData.Split('|');

            //attach the roles to the user with the principal object so the roles follow the user
             HttpContext.Current.User = new GenericPrincipal(fi, astrRoles);

        }
    }
}

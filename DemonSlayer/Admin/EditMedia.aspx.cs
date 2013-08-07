using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemonSlayer.Admin
{
    public partial class EditMedia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        //upload media info to media table in the db and upload th media to the sever
        protected void btnUploadMedia_Click(object sender, EventArgs e)
        {
          string location = "/Media/" + fupMedia.FileName;
          fupMedia.SaveAs(AppDomain.CurrentDomain.BaseDirectory + location);
          BusinessRules.CMedia objPost = new BusinessRules.CMedia();
          objPost.Title = txtTitle.Text;
          objPost.Location = location;
          objPost.UserID = BusinessRules.CUser.getIDByName(HttpContext.Current.User.Identity.Name);
          objPost.save();
          Response.Redirect("/Media.aspx", true);
        }
    }
}
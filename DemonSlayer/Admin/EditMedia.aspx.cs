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
          if (IsPostBack == false)
          {
            getMedia();
          }
        }

        // this method gets all media from the database using CMedia class
        protected void getMedia()
        {
          BusinessRules.CMedia objMedia = new BusinessRules.CMedia();

          gvMedia.DataSource = objMedia.getMedia();
          gvMedia.DataBind();
        }

        //this method deletes rows from the Media table in the database using the CMedia class
        protected void gvMedia_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
          BusinessRules.CMedia objMedia = new BusinessRules.CMedia();

          objMedia.deleteMedia(Convert.ToInt32(gvMedia.DataKeys[e.RowIndex].Values["MediaID"].ToString()));
          getMedia();
        }

        //confirm delete
        protected void gvMedia_RowDataBound(object sender, GridViewRowEventArgs e)
        {
          e.Row.Cells[4].Attributes.Add("onclick", "return confirm('Are you sure?');");
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
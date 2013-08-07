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
        if (IsPostBack == false)
        {
          getPosts();
        }
      }
      
      // this method gets all posts from the database using CPost class
      protected void getPosts()
      {
        BusinessRules.CPost objPost = new BusinessRules.CPost();
             
        gvPosts.DataSource = objPost.getPosts();
        gvPosts.DataBind();
      }
      
      //this method deletes rows from the posts table in the database using the CPost class
      protected void gvPosts_RowDeleting(object sender, GridViewDeleteEventArgs e)
      {
        BusinessRules.CPost objPost = new BusinessRules.CPost();

        objPost.deletePost(Convert.ToInt32(gvPosts.DataKeys[e.RowIndex].Values["PostID"].ToString()));
        getPosts();
      }
      
      //confirm delete
      protected void gvPosts_RowDataBound(object sender, GridViewRowEventArgs e)
      {
        e.Row.Cells[4].Attributes.Add("onclick", "return confirm('Are you sure?');");
      }
    }
}
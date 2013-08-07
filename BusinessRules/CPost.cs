using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace BusinessRules
{
  public class CPost
  {
    SqlConnection objConn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["strConn"].ConnectionString);
    private string _post;
    private int _userID;
    private int _postID;

    public string Post
    {
      get { return _post; }
      set { _post = value; }
    }

    public int UserID
    {
      get { return _userID; }
      set { _userID = value; }
    }

    public int PostID
    {
      get { return _postID; }
      set { _postID = value; }
    }

    public void save()
    {
      objConn.Open();
      string postSQL = "";
      if (PostID > 0)
      {
        postSQL = "UPDATE posts SET Post='" + Post + "', UserID='" + UserID + "' WHERE PostID='" + PostID + "';";
      }
      else
      {
        postSQL = "INSERT INTO posts (Post, UserID) VALUES ('" + Post + "', " + UserID + ")";
      }

      SqlCommand objCmd = new SqlCommand(postSQL, objConn);
      objCmd.ExecuteNonQuery();

      objCmd.Dispose();
      objConn.Close();
    }

    public static string getPostByID(int postID)
    {
      string post = "";

      SqlConnection objConn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["strConn"].ConnectionString);
      objConn.Open();

      string getPostSQL = "SELECT Post FROM posts WHERE PostID='" + postID + "'";

      SqlCommand objCmd = new SqlCommand(getPostSQL, objConn);
      SqlDataReader objRdr = objCmd.ExecuteReader();

      while (objRdr.Read())
      {
        post = objRdr.GetString(0);
      }

      objCmd.Dispose();
      objConn.Close();
      return post;
    }

    public SqlDataReader getPosts()
    {

      objConn.Open();

      string strSQL = "SELECT PostID, UserID, Post FROM Posts";
      SqlCommand objCmd = new SqlCommand(strSQL, objConn);

      SqlDataReader objRdr = objCmd.ExecuteReader();
      return objRdr;
    }

    public void deletePost(int PostID)
    {
      objConn.Open();
      string strSQL = "DELETE FROM Posts WHERE PostID = " + PostID.ToString();

      SqlCommand objCmd = new SqlCommand(strSQL, objConn);
      objCmd.ExecuteNonQuery();

      objCmd.Dispose();
      objConn.Close();
    }
  }
}

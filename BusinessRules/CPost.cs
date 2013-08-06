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

    public void save()
    {
      objConn.Open();

      string postSQL = "INSERT INTO posts (Post, UserID) VALUES ('" + Post + "', " + UserID + ")";

      SqlCommand objCmd = new SqlCommand(postSQL, objConn);
      objCmd.ExecuteNonQuery();

      objCmd.Dispose();
      objConn.Close();
    }
  }
}

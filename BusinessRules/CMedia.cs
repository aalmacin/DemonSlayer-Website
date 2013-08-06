using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BusinessRules
{
  public class CMedia
  {
    SqlConnection objConn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["strConn"].ConnectionString);

    private int _userID;
    private string _title;
    private string _location;

    public int UserID
    {
      get { return _userID; }
      set { _userID = value; }
    }

    public string Title
    {
      get { return _title; }
      set { _title = value; }
    }

    public string Location
    {
      get { return _location; }
      set { _location = value; }
    }

    public void save()
    {
      objConn.Open();

      string mediaSQL = "INSERT INTO media (Title, Location, UserID) VALUES ('" + Title + "', '" + Location + "', " + UserID + ")";

      SqlCommand objCmd = new SqlCommand(mediaSQL, objConn);
      objCmd.ExecuteNonQuery();

      objCmd.Dispose();
      objConn.Close();
    }
  }
}

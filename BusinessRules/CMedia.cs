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

    // Getters and setters.
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

    // Saves the media info in the media table.
    public void save()
    {
      // Open a connection.
      objConn.Open();

      // The query to save the media.
      string mediaSQL = "INSERT INTO media (Title, Location, UserID) VALUES ('" + Title + "', '" + Location + "', " + UserID + ")";

      // Run the query.
      SqlCommand objCmd = new SqlCommand(mediaSQL, objConn);
      objCmd.ExecuteNonQuery();

      objCmd.Dispose();
      objConn.Close();
    }
  }
}

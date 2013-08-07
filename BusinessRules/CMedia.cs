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

    //get a list of all Media in the Media table
    public SqlDataReader getMedia()
    {

      objConn.Open();
      //query
      string strSQL = "SELECT MediaID, UserID, Title, Location FROM Media";
      SqlCommand objCmd = new SqlCommand(strSQL, objConn);

      SqlDataReader objRdr = objCmd.ExecuteReader();
      return objRdr;

    }
    //delete specified Media form table. needs MediaID
    public void deleteMedia(int MediaID)
    {
      objConn.Open();
      //query
      string strSQL = "DELETE FROM Media WHERE MediaID = " + MediaID.ToString();

      SqlCommand objCmd = new SqlCommand(strSQL, objConn);
      objCmd.ExecuteNonQuery();

      objCmd.Dispose();
      objConn.Close();
    }
  }
}

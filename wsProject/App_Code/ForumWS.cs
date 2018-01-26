using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ForumWS
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class ForumWS : System.Web.Services.WebService
{
    private static string _ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\אדר\\Desktop\\פרויקט במחשבים1\\App_Data\\Database.mdf\";Integrated Security=True"; 
    public ForumWS()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    //post(Thread): add new + delete + get + set
    [WebMethod]
    public bool AddPost(string title, string content, int posterID)
    {
        try
        {
            string query = "INSERT INTO Threads(Title,Content,PosterID) VALUES(@1, @2, @3);";
            SqlConnection conn = new SqlConnection(_ConnectionString);
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@1", title);
            comm.Parameters.AddWithValue("@2", content);
            comm.Parameters.AddWithValue("@3", posterID);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        catch
        {
            return false;
        }
    }

    [WebMethod]
    public string GetPostTitle(int postId)
    {
        try
        {
            string query = "SELECT Title FROM Threads WHERE id = @1;";
            SqlConnection conn = new SqlConnection(_ConnectionString);
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@1", postId);
            conn.Open();
            string title = comm.ExecuteScalar().ToString();
            conn.Close();
            return title;
        }
        catch
        {
            return "User does not exists";
        }
    }

    [WebMethod]
    public string GetPostContent(int postId)
    {
        try
        {
            string query = "SELECT Content FROM Threads WHERE id = @1;";
            SqlConnection conn = new SqlConnection(_ConnectionString);
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@1", postId);
            conn.Open();
            string title = comm.ExecuteScalar().ToString();
            conn.Close();
            return title;
        }
        catch
        {
            return "User does not exists";
        }
    }

    [WebMethod]
    public string GetPostTitleByPoster(int posterId)
    {
        try
        {
            string query = "SELECT Title FROM Threads WHERE PosterID = @1;";
            SqlConnection conn = new SqlConnection(_ConnectionString);
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@1", posterId);
            conn.Open();
            string title = comm.ExecuteScalar().ToString();
            conn.Close();
            return title;
        }
        catch
        {
            return "User does not exists";
        }
    }

    [WebMethod]
    public string GetPostContentByPoster(int posterId)
    {
        try
        {
            string query = "SELECT Content FROM Threads WHERE PosterID = @1;";
            SqlConnection conn = new SqlConnection(_ConnectionString);
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@1", posterId);
            conn.Open();
            string title = comm.ExecuteScalar().ToString();
            conn.Close();
            return title;
        }
        catch
        {
            return "User does not exists";
        }
    }

    [WebMethod]
    public bool SetPostTitle(int postId, string title)
    {
        try
        {
            string query = "UPDATE Threads SET Title = @2 WHERE PosterID = @1;";
            SqlConnection conn = new SqlConnection(_ConnectionString);
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@1", postId);
            comm.Parameters.AddWithValue("@2", title);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        catch
        {
            return false;
        }
    }

    [WebMethod]
    public bool SetPostTitleByPoster(int posterId, string title)
    {
        try
        {
            string query = "UPDATE Threads SET Title = @2 WHERE PosterID = @1;";
            SqlConnection conn = new SqlConnection(_ConnectionString);
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@1", posterId);
            comm.Parameters.AddWithValue("@2", title);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        catch
        {
            return false;
        }
    }

    [WebMethod]
    public bool SetPostContent(int postId, string content)
    {
        try
        {
            string query = "UPDATE Threads SET Content = @2 WHERE PosterID = @1;";
            SqlConnection conn = new SqlConnection(_ConnectionString);
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@1", postId);
            comm.Parameters.AddWithValue("@2", content);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        catch
        {
            return false;
        }
    }

    [WebMethod]
    public bool SetCommentPostByPoster(int posterId, string content)
    {
        try
        {
            string query = "UPDATE Threads SET Content = @2 WHERE PosterID = @1;";
            SqlConnection conn = new SqlConnection(_ConnectionString);
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@1", posterId);
            comm.Parameters.AddWithValue("@2", content);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        catch
        {
            return false;
        }
    }

    [WebMethod]
    public bool DeletePost(int postID)
    {
        try
        {
            string query = "DELETE * FROM Posts WHERE id = @1;";
            SqlConnection conn = new SqlConnection(_ConnectionString);
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@1", postID);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        catch
        {
            return false;
        }
    }

    [WebMethod]
    public bool DeletePostByPoster(int posterID)
    {
        try
        {
            string query = "DELETE * FROM Posts WHERE PosterID = @1;";
            SqlConnection conn = new SqlConnection(_ConnectionString);
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@1", posterID);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        catch
        {
            return false;
        }
    }

    //comment: add new + delete + get + set
    [WebMethod]
    public bool AddComment(string content, int posterID)
    {
        try
        {
            string query = "INSERT INTO Comments(Content,PosterID) VALUES(@1, @2);";
            SqlConnection conn = new SqlConnection(_ConnectionString);
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@1", content);
            comm.Parameters.AddWithValue("@2", posterID);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        catch
        {
            return false;
        }
    }

    [WebMethod]
    public string GetCommentContent(int postId)
    {
        try
        {
            string query = "SELECT Content FROM Comments WHERE id = @1;";
            SqlConnection conn = new SqlConnection(_ConnectionString);
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@1", postId);
            conn.Open();
            string title = comm.ExecuteScalar().ToString();
            conn.Close();
            return title;
        }
        catch
        {
            return "User does not exists";
        }
    }

    [WebMethod]
    public string GetCommentContentByPoster(int posterId)
    {
        try
        {
            string query = "SELECT Content FROM Comments WHERE PosterID = @1;";
            SqlConnection conn = new SqlConnection(_ConnectionString);
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@1", posterId);
            conn.Open();
            string title = comm.ExecuteScalar().ToString();
            conn.Close();
            return title;
        }
        catch
        {
            return "User does not exists";
        }
    }

    [WebMethod]
    public bool SetCommentContent(int postId, string content)
    {
        try
        {
            string query = "UPDATE Comments SET Content = @2 WHERE PosterID = @1;";
            SqlConnection conn = new SqlConnection(_ConnectionString);
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@1", postId);
            comm.Parameters.AddWithValue("@2", content);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        catch
        {
            return false;
        }
    }

    [WebMethod]
    public bool SetCommentContentByPoster(int posterId, string content)
    {
        try
        {
            string query = "UPDATE Comments SET Content = @2 WHERE PosterID = @1;";
            SqlConnection conn = new SqlConnection(_ConnectionString);
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@1", posterId);
            comm.Parameters.AddWithValue("@2", content);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        catch
        {
            return false;
        }
    }

    [WebMethod]
    public bool DeleteComment(int postID)
    {
        try
        {
            string query = "DELETE * FROM Comments WHERE id = @1;";
            SqlConnection conn = new SqlConnection(_ConnectionString);
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@1", postID);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        catch
        {
            return false;
        }
    }

    [WebMethod]
    public bool DeleteCommentByPoster(int posterID)
    {
        try
        {
            string query = "DELETE * FROM Comments WHERE PosterID = @1;";
            SqlConnection conn = new SqlConnection(_ConnectionString);
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@1", posterID);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        catch
        {
            return false;
        }
    }

}

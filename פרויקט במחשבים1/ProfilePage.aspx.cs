using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

public partial class ProfilePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string c = "Data Source = (LocalDB)\\MSSQLLocalDB;";
        c += "AttachDbFilename = \"C:\\Users\\אדר\\Desktop\\פרויקט במחשבים1\\App_Data\\Database.mdf\";";
        c += "Integrated Security = True";

        SqlConnection conn = new SqlConnection(c);
        conn.Open();
        
        if (imgUpload.HasFile)
        {
            int length = imgUpload.PostedFile.ContentLength;

            byte[] pic = new byte[length];
            imgUpload.PostedFile.InputStream.Read(pic, 0, length);
            SqlCommand cmd = new SqlCommand("UPDATE Users SET Image = @1 where UserName = @2;", conn);
            cmd.Parameters.AddWithValue("@1", pic);
            cmd.Parameters.AddWithValue("@2", Session["user"].ToString());
            cmd.ExecuteNonQuery();
        }
        conn.Close();
        
    }
}
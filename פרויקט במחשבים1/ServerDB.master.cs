using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows.Forms;

public partial class ServerDB : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        string UserName = txtUserName.Text, Password = txtPassword.Text, DBpassword, FirstName;
        if(UserName == "Admin" && Password == "Admin")
        {
            Session["User"] = "Admin";
            
        }
        else if (UserName.Length > 1 && Password.Length > 1)
        {
            string c = "Data Source = (LocalDB)\\MSSQLLocalDB;";
            c += "AttachDbFilename = \"C:\\Users\\אדר\\Desktop\\פרויקט במחשבים1\\App_Data\\Database.mdf\";";
            c += "Integrated Security = True";

            SqlConnection conn = new SqlConnection(c);

            SqlCommand comm = new SqlCommand("SELECT Upassword AS password, FirstName FROM Users WHERE UserName = @1;", conn);
            comm.Parameters.AddWithValue("@1", UserName);

            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                DBpassword = (string)reader["password"];
                FirstName = (string)reader["FirstName"];

                if (DBpassword.Length > 0 && Password == DBpassword)
                {
                    Session["User"] = FirstName;
                }
                else if (DBpassword.Length > 0 && Password != DBpassword)
                {
                    MessageBox.Show("Passwords Don`t Match");
                }
                else
                {
                    MessageBox.Show("UserName Does not Exist.");
                }
            }
            reader.Close();
            conn.Close();
        }
        Userlbl.InnerText = "Welcome back " + Session["User"].ToString();
        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "OnLoad(), CheckAdmin()", true);
        
    }

    protected void LogOut_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Userlbl.InnerText = string.Empty;
    }
}

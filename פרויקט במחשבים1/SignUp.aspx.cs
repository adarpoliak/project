using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows.Forms;

public partial class SignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            if (!CheckTaken(txtUserName.Text))
            {
                string c = "Data Source = (LocalDB)\\MSSQLLocalDB;";
                c += "AttachDbFilename = \"C:\\Users\\אדר\\Desktop\\פרויקט במחשבים1\\App_Data\\Database.mdf\";";
                c += "Integrated Security = True";

                SqlConnection conn = new SqlConnection(c);


                SqlCommand comm = new SqlCommand("INSERT INTO Users VALUES(@1, @2, @3, @4, @5);", conn);
                comm.Parameters.AddWithValue("@1", txtFirstName.Text);
                comm.Parameters.AddWithValue("@2", txtLastName.Text);
                comm.Parameters.AddWithValue("@3", txtUserName.Text);
                comm.Parameters.AddWithValue("@4", txtPassword.Text);
                comm.Parameters.AddWithValue("@5", txtEmail.Text);

                conn.Open();
                comm.ExecuteNonQuery();
                conn.Close();
                Session["User"] = txtFirstName.Text;
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                MessageBox.Show("UserName Taken");
                ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "text", "Validation()", true);
            }
        }

        else
        {

        }
    }

    public static bool CheckTaken(string UserName)
    {
        string c = "Data Source = (LocalDB)\\MSSQLLocalDB;";
        c += "AttachDbFilename = \"C:\\Users\\אדר\\Desktop\\פרויקט במחשבים1\\App_Data\\Database.mdf\";";
        c += "Integrated Security = True";
        string query = "SELECT COUNT(UserName) FROM Users WHERE UserName = @1;";
        SqlConnection conn = new SqlConnection(c);

        SqlCommand com = new SqlCommand(query, conn);
        com.Parameters.AddWithValue("@1", UserName);
        conn.Open();
        int i = Convert.ToInt32(com.ExecuteScalar());
        conn.Close();
        return i > 0;
    }



}
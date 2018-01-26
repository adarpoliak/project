using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
//using System.Windows.Forms;

public partial class ServerDB : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        string UserName = txtUserName.Text, Password = txtPassword.Text;
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

            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserName = @1 AND Upassword = @2;", conn);
            comm.Parameters.AddWithValue("@1", UserName);
            comm.Parameters.AddWithValue("@2", Password);

            conn.Open();
            int reader = (int)comm.ExecuteScalar();
            
            if (reader == 1)
            {
                Session["User"] = UserName;
            }
            else
            {
                Response.Write("<script>alert(UserName Or password are wrong)</script>");
            }
            conn.Close();
        }

        Userlbl.Text +=  Session["User"];
        if(Session["User"].ToString() != null)
        {
            if (Session["User"].ToString() == "Admin")
            {
                AdminLink.Attributes.Remove("class");
                AdminLink.Attributes.Add("class", "loged-in");
            }
            SignUp.Attributes.Remove("class");
            SignUp.Attributes.Add("class", "loged-out");
        }
        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "OnLoad() ", true);
        
    } 

    protected void LogOut_Click(object sender, EventArgs e)
    {
        string temp = Session["User"].ToString();
        Session.Clear();
        Userlbl.Text = "welcome ";
        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "CallMyFunction", "OnLoad()", true);
        SignUp.Attributes.Remove("class");
        SignUp.Attributes.Add("class", "loged-in");
        if(temp == "Admin")
        {
            SignUp.Attributes.Remove("class");
            SignUp.Attributes.Add("class", "loged-out");
        }
    }
}

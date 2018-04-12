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
        if (Session["User"] != null)
        {
            LogedIn(sender, e);    
            Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "OnLoad() ", true);
        }
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        string UserName = txtUserName.Text, Password = txtPassword.Text;

        if (UserName.Length > 1 && Password.Length > 1)
        {
            try
            {
                txtUserName.CssClass.Replace("notvalid", "");
                txtPassword.CssClass.Replace("notvalid", "");
                PasswordToolTip.Style.Add("display", "none");
                UserNameToolTip.Style.Add("display", "none");
            }
            finally
            {
                string c = "Data Source = (LocalDB)\\MSSQLLocalDB;";
                c += "AttachDbFilename = \"C:\\Users\\אדר\\Desktop\\פרויקט במחשבים1\\App_Data\\Database.mdf\";";
                c += "Integrated Security = True";

                SqlConnection conn = new SqlConnection(c);

                SqlCommand comm = new SqlCommand("SELECT FirstName, IsAdmin, Id FROM Users WHERE UserName = @1 AND Upassword = @2;", conn);
                comm.Parameters.AddWithValue("@1", UserName);
                comm.Parameters.AddWithValue("@2", Password);

                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        Session["User"] = reader[0].ToString();

                        if ((bool)reader[1])
                            Session["Admin"] = "true";
                        else
                        {
                            Session["Admin"] = "false";
                        }
                        Session["Id"] = reader[2].ToString();
                    }
                    else
                    {
                        txtPassword.CssClass += "notvalid";
                        txtUserName.CssClass += "notvalid";
                        Label1.Text = "UserName Or Password are incorrect!";
                        Label2.Text = "UserName Or Password are incorrect!";
                        PasswordToolTip.Style.Add("display", "normal");
                        UserNameToolTip.Style.Add("display", "normal");
                    }
                }

                conn.Close();


            }
        }
        else
        {
            txtPassword.CssClass += "notvalid";
            txtUserName.CssClass += "notvalid";
            Label1.Text = "UserName cannot be empty!";
            Label2.Text = "Password cannot be empty!";
            PasswordToolTip.Style.Add("display", "normal");
            UserNameToolTip.Style.Add("display", "normal");
        }

            
    }

    protected void LogOut_Click(object sender, EventArgs e)
    {
        Session.Clear();
        
        AdminLink.Attributes.Remove("class");
        AdminLink.Attributes.Add("class", "loged-out");
        SignUp.Attributes.Remove("class");
        SignUp.Attributes.Add("class", "loged-in");
        UserLabel.Attributes.Remove("class");
        UserLabel.Attributes.Add("class", "loged-out");
        SignIn.Attributes.Remove("class");
        SignIn.Attributes.Add("class", "loged-in");
        Li4.Attributes.Remove("class");
        Li4.Attributes.Add("class", "loged-out");
    }

    protected void LogedIn(object sender, EventArgs e)
    {
        if (Session["User"] != null)
        {
            if (Session["Admin"].ToString() == "true")
            {
                AdminLink.Attributes.Remove("class");
                AdminLink.Attributes.Add("class", "loged-in");
            }
            
            SignUp.Attributes.Remove("class");
            SignUp.Attributes.Add("class", "loged-out");
            UserLabel.Attributes.Remove("class");
            UserLabel.Attributes.Add("class", "loged-in dropdown");
            SignIn.Attributes.Remove("class");
            SignIn.Attributes.Add("class", "loged-out changed");
            Li4.Attributes.Remove("class");
            Li4.Attributes.Add("class", "loged-in dropdown");
            ProfileLink.NavigateUrl = "http://localhost:51060/ProfilePage.aspx?id=" + Session["Id"].ToString();
            Userlbl.Text = "Welcome " + Session["User"].ToString();
        }
    }

    
}

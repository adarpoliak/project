using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows.Forms;

public partial class AdminPage : System.Web.UI.Page
{
    string _c = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\אדר\\Desktop\\פרויקט במחשבים\\YudBetWebSite\\App_Data\\ServerDB.mdf\"; Integrated Security=True";

    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(_c);
        SqlCommand Reader = new SqlCommand("SELECT * FROM Users", conn);

        conn.Open();
        UsersGV.DataSource = Reader.ExecuteReader();
        UsersGV.DataBind();
        conn.Close();
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        string confirmValue = Request.Form["confirm_value"];
        if (confirmValue == "Yes")
        {

        }
        else
        {
            
        }
    }
}
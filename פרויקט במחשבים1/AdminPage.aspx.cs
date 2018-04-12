using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows.Forms;
using ForumsWS;

public partial class AdminPage : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

        ForumWS ws = new ForumWS();
        SqlConnection conn = new SqlConnection(conString.constring);

        SqlCommand comm = new SqlCommand("SELECT Id, FirstName AS [First Name], LastName AS [Last Name], UserName, Upassword AS Password, Email FROM Users;", conn);
        conn.Open();
        SqlDataReader reader = comm.ExecuteReader();
        allUserGV.DataSource = reader;
        allUserGV.DataBind();
        conn.Close();

        productsGV.DataSource = ws.GetAllProducts();
        productsGV.DataBind();
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string Id = txtSearchByID.Text;
        string Name = txtSearchByName.Text;

        if(Id != "")
        {
            SqlConnection con = new SqlConnection(conString.constring);
            SqlCommand comm = new SqlCommand("SELECT Id, FirstName AS [First Name], LastName AS [Last Name], UserName, Upassword AS Password, Email FROM Users WHERE Id = @1;", con);
            comm.Parameters.AddWithValue("@1", Id);
            con.Open();
            SqlDataReader reader = comm.ExecuteReader();
            searchGV.DataSource = reader;
            searchGV.DataBind();
            con.Close();
        }
        else if(Id == "" && Name != "")
        {
            SqlConnection con = new SqlConnection(conString.constring);
            SqlCommand comm = new SqlCommand("SELECT Id, FirstName AS [First Name], LastName AS [Last Name], UserName, Upassword AS Password, Email FROM Users WHERE FirstName = @1 OR LastName = @1;", con);
            comm.Parameters.AddWithValue("@1", Name);
            con.Open();
            SqlDataReader reader = comm.ExecuteReader();
            searchGV.DataSource = reader;
            searchGV.DataBind();
            con.Close();
        }
    }

    protected void btnSearchD_Click(object sender, EventArgs e)
    {
        string Id = txtById.Text;

        if (Id != "")
        {
            SqlConnection con = new SqlConnection(conString.constring);
            SqlCommand comm = new SqlCommand("SELECT Id, FirstName AS [First Name], LastName AS [Last Name], UserName, Upassword AS Password, Email FROM Users WHERE Id = @1;", con);
            comm.Parameters.AddWithValue("@1", Id);
            con.Open();
            SqlDataReader reader = comm.ExecuteReader();
            deleteGV.DataSource = reader;
            deleteGV.DataBind();
            con.Close();
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        string Id = txtById.Text;

        SqlConnection con = new SqlConnection(conString.constring);
        SqlCommand comm = new SqlCommand("DELETE FROM Users WHERE Id = @1;", con);
        comm.Parameters.AddWithValue("@1", Id);
        con.Open();
        comm.ExecuteNonQuery();    
        con.Close();
        Response.Redirect(Request.RawUrl);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(conString.constring);

        SqlCommand comm = new SqlCommand("INSERT INTO Users VALUES(@1, @2, @3, @4, @5);", conn);
        comm.Parameters.AddWithValue("@1", txtFirstName.Text);
        comm.Parameters.AddWithValue("@2", txtLastName.Text);
        comm.Parameters.AddWithValue("@3", txtUserName.Text);
        comm.Parameters.AddWithValue("@4", txtPassword.Text);
        comm.Parameters.AddWithValue("@5", txtEmail.Text);

        conn.Open();
        comm.ExecuteNonQuery();
        conn.Close();

        Response.Redirect(Request.RawUrl);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        ForumWS ws = new ForumWS();
        string name, descrition, colors= "", category;
        int price;
        try
        {
            if (txtName.Text != "" && txtDescription.Text != "" && txtPrice.Text != "")
            {
                name = txtName.Text;
                descrition = txtDescription.Text;
                price = int.Parse(txtPrice.Text);
                category = listCategory.Text;
                foreach(ListItem colour in CheckBoxList1.Items)
                {
                    if (colour.Selected)
                        colors += "$" + colour.Text;
                }

                ws.AddProduct(name, descrition, price, colors);
            }
        }
        catch
        {
            Response.Write("Something weng wrong...");
        }
    }
}
public static class conString
{
       public const string constring = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"C:\\Users\\אדר\\Desktop\\פרויקט במחשבים1\\App_Data\\Database.mdf\"; Integrated Security = True";
}
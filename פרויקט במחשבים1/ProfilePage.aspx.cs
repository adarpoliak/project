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
        try
        {
            HeadLine.InnerText = Session["User"].ToString() + "'s Profile Page";
        }
        catch (Exception ex)
        {
            HeadLine.InnerText = "something went wrong.." + ex.Message;
        }
    }



    /// <summary>
    /// changes the Users password 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnChangePass_Click(object sender, EventArgs e)
    {
        //string id = HttpContext.Current.Request.QueryString["id"];
        string id = Session["Id"].ToString();
        if (txtConfirmPass.Text == "" && txtNewPass.Text == "" && txtOldPass.Text == "")
        {
            lblError.Text = "-Fields musnt remain empty!";
        }
        else if (txtNewPass.Text != txtConfirmPass.Text)
        {
            lblError.Text = "-Passwords do not Match! ";
        }
        else //if the passwords match - check if the old password is correct
        {
            string c = "Data Source = (LocalDB)\\MSSQLLocalDB;";
            c += "AttachDbFilename = \"C:\\Users\\אדר\\Desktop\\פרויקט במחשבים1\\App_Data\\Database.mdf\";";
            c += "Integrated Security = True";
            

            SqlConnection conn = new SqlConnection(c);

            SqlCommand comm = new SqlCommand("UPDATE Users SET Upassword = @1 WHERE Id = @2 AND Upassword = @3;", conn);
            comm.Parameters.AddWithValue("@1", txtNewPass.Text);
            comm.Parameters.AddWithValue("@2", id);
            comm.Parameters.AddWithValue("@3", txtOldPass.Text);

            conn.Open(); //open the connextion to the DB 
            
            try
            {
                int count = comm.ExecuteNonQuery();//returns num of rows updated 
                if(count > 0)
                {
                    lblError.Text = "Password Updated Succesfully!";
                }
                else //if no row was updated => the old password is wrong
                {
                    lblError.Text = "-Old Password is incorrect!";
                }
            }
            catch(SqlException ex)
            {
                lblError.Text += " -Update failed cuz.." + ex.Message;
            }
            conn.Close();
        }
    }

}

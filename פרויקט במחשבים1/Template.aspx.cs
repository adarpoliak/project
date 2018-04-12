using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ForumsWS;


public partial class Template : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ForumWS ws = new ForumWS();
        try
        {
            //defining the variables 
            string color, _description, name;
            int price;
            name = ws.GetProductName(GetId(sender, e));
            _description = ws.GetProductDescription(GetId(sender, e));
            color = ws.GetProductColor(GetId(sender, e));
            price = ws.GetProductPrice(GetId(sender, e));

            ProductTitle.InnerHtml = name;
            description.InnerHtml = _description;
            Price.Text += " " + price.ToString() + "NIS";
            //creates color select list
            char stringseperator = '$'; 
            string[] colors = color.Split(stringseperator);
            foreach(string colour in colors)
            {
                Color_Select.Items.Add(colour);
            }

        }
        catch
        {


        }
        

    }

    public int GetId(object sender, EventArgs e)
    {
        return int.Parse(Page.Request.QueryString["productId"]);
    }
}

public static class Constants
{
    public const string constring = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"C:\\Users\\אדר\\Desktop\\פרויקט במחשבים1\\App_Data\\Database.mdf\"; Integrated Security = True";
    
}
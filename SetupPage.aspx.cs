using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SetUpPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Session["Theme"] != null)
        {
            Page.Theme = Session["Theme"].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["Theme"] = "Black";
        Server.Transfer(Request.FilePath);
    }

    protected void btnLightTheme_Click(object sender, EventArgs e)
    {
        Session["Theme"] = "White";
        Server.Transfer(Request.FilePath);
    }
    

}
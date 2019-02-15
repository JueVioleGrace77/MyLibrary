using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Authentication : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Session["Theme"] != null)
        {
            Page.Theme = Session["Theme"].ToString();
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (User.Identity.IsAuthenticated)
        {
            lblUserAuthentication.Text = "Welcome: " + User.Identity.Name;
        }
        else
        {
            lblUserAuthentication.Text = "No user identity available..";
            btnLogOut.Enabled = false;
        }
    }

    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        Response.Redirect("~/Home.aspx");
    }

    protected void btnLogIn_Click(object sender, EventArgs e)
    {
        if (User.Identity.IsAuthenticated)
        {
            lblCheckLoggedUser.Text = User.Identity.Name + " is already logged in";
        }
        else
        {
            Response.Redirect("~/Login.aspx");
        }
    }
}
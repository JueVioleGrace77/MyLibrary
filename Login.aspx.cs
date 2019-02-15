using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;

public partial class Login : System.Web.UI.Page
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
    protected void btn_Login_Click(object sender, EventArgs e)
    {
        GetUserName_Password();
    }
    private void GetUserName_Password()
    {
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader reader;
        string connectionString = ConfigurationManager.ConnectionStrings["BOOKS"].ConnectionString;
        conn = new SqlConnection(connectionString);
        comm = new SqlCommand("SELECT password FROM [LOGIN] WHERE userName = '" + txtUserName.Text + "'", conn);

        conn.Open();
        reader = comm.ExecuteReader();
        bool Checker = false;
        while (reader.Read())
        {
            if (reader[0].Equals(txtPassword.Text))
            {  
                FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, chkPersist.Checked);
                Checker = true;
                Response.Redirect("~/Home.aspx");
            }
        }
        if (!Checker)
        {
            lblLoginChecker.Text = "Invalid credentials. Please try again.";
        }
      conn.Close();
    }

    protected void btn_cancel_Click(object sender, EventArgs e)
    {
        txtUserName.Text = string.Empty;
        txtPassword.Text = string.Empty;
    }
}
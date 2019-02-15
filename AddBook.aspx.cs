using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;


public partial class AddBook : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection conn;
            string connectionString = ConfigurationManager.ConnectionStrings["BOOKS"].ConnectionString;
            conn = new SqlConnection(connectionString);
            string commGenre = "SELECT DISTINCT Genre FROM Books";
            SqlDataAdapter adpt = new SqlDataAdapter(commGenre, conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            drpGenre.DataSource = dt;
            drpGenre.DataTextField = "Genre";
            drpGenre.DataBind();
        }
    }

    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Session["Theme"] != null)
        {
            Page.Theme = Session["Theme"].ToString();
        }
    }
    protected void save_Click(object sender, EventArgs e)
    {
        if (chkLandedToAFriend.Checked == true)
        {
            chkLandedToAFriend.Text = "Yes";
        }
        else
        {
            chkLandedToAFriend.Text = "No";
        }
        SqlConnection conn;
        string connectionString = ConfigurationManager.ConnectionStrings["BOOKS"].ConnectionString;
        conn = new SqlConnection(connectionString);
        conn.Open();
        SqlCommand comm;     
        comm = new SqlCommand("SET IDENTITY_INSERT [Books] ON " +
            "INSERT into Books ([BookId], [BookTitle], [Author], [ISBN], [Genre], [NumberOfPage], [LandedToAFriend], [NameOfFriend],[Comment]) " +
            "VALUES (NEXT VALUE FOR BookId_Seq, '" + book.BookTiTle+"','"+book.Author+"','"+book.ISBN+"','"+drpGenre.Text+"','"+txtNumberOfPage.Text+"','"+chkLandedToAFriend.Text+"','"+txtNameToAFriendLanded.Text+"','"+AreaComment.InnerText+"')", conn);
        comm.ExecuteNonQuery();
        conn.Close();
        Response.Redirect("Book.aspx");
    }

    protected void cancel_Click(object sender, EventArgs e)
    {
        book.BookTiTle = string.Empty;
        book.Author = string.Empty;
        book.ISBN = string.Empty;
        txtNumberOfPage.Text = string.Empty;
        txtNameToAFriendLanded.Text = string.Empty;
        AreaComment.InnerText = string.Empty;
    }

    protected void landedToAFriend_CheckedChanged(object sender, EventArgs e)
    {
        if (chkLandedToAFriend.Checked == true)
        {
            RequiredFieldValidator4.Enabled = true;
        }
        else if (chkLandedToAFriend.Checked == false)
        {
            RequiredFieldValidator4.Enabled = false;
        }
    }
}
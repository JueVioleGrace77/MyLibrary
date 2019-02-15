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

public partial class Search : System.Web.UI.Page
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
        if (!IsPostBack)
        {
            SqlConnection conn;
            string connectionString = ConfigurationManager.ConnectionStrings["BOOKS"].ConnectionString;
            conn = new SqlConnection(connectionString);
            string commGenre = "SELECT DISTINCT Genre FROM Books";
            SqlDataAdapter adpt = new SqlDataAdapter(commGenre, conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            genreDropDownList.DataSource = dt;
            genreDropDownList.DataTextField = "Genre";
            genreDropDownList.DataBind();

            string commFriend = "SELECT DISTINCT NameOfFriend FROM Books";
            SqlDataAdapter adpt2 = new SqlDataAdapter(commFriend, conn);
            DataTable dt2 = new DataTable();
            adpt2.Fill(dt2);
            friendLandedToDropDownList.DataSource = dt2;
            friendLandedToDropDownList.DataTextField = "NameOfFriend";
            friendLandedToDropDownList.DataBind();
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        GridBind();
    }

    private void GridBind()
    {
        SqlDataSource sds = new SqlDataSource();
        sds.ConnectionString = ConfigurationManager.ConnectionStrings["BOOKS"].ToString();
        sds.SelectParameters.Add("Genre", TypeCode.String, genreDropDownList.Text);
        sds.SelectParameters.Add("NameOfFriend", TypeCode.String, friendLandedToDropDownList.Text);
        sds.SelectCommand = "SELECT BookTitle, NameOfFriend, Genre FROM [Books] WHERE [Genre] = @Genre AND [NameOfFriend] = @NameOfFriend";
        DataView dv = (DataView)sds.Select(DataSourceSelectArguments.Empty);

        if (dv.Count == 0)
        {
            recordLabel.Text = "No Data Found";
            recordLabel.EnableViewState = true;
            return;
        }
        else
        {
            grid.EnableViewState = true;
            grid.DataSource = sds;
            grid.DataBind();
        }
    }
}
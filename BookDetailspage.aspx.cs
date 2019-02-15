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

public partial class BookDetailspage : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Session["Theme"] != null)
        {
            Page.Theme = Session["Theme"].ToString();
        }
    }
    int bookId = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        bookId = Convert.ToInt32(Request.QueryString["BookNum"].ToString());
        if (!IsPostBack)
        {
            BindTextBoxvalues();
        }
        //TextBoxes
        txtBookTitle.Enabled = false;
        txtAuthorName.Enabled = false;
        txtIsbnNumber.Enabled = false;
        txtGenre.Enabled = false;
        txtNumberOfPage.Enabled = false;
        txtNameToAFriendLanded.Enabled = false;
        AreaComment.Disabled = true;
        //Buttons
        btnUpload.Enabled = false;
        btnCancel.Enabled = false;
    }

    private void BindTextBoxvalues()
    {
        string constr = ConfigurationManager.ConnectionStrings["Books"].ConnectionString;
        SqlConnection conn = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand("SELECT BookTitle, Author, ISBN, Genre, NumberOfPage, NameOfFriend, Comment " +
                              "FROM Books WHERE BookId =" + bookId, conn);
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        txtBookTitle.Text = dt.Rows[0][0].ToString();
        txtAuthorName.Text = dt.Rows[0][1].ToString();
        txtIsbnNumber.Text = dt.Rows[0][2].ToString();
        txtGenre.Text = dt.Rows[0][3].ToString();
        txtNumberOfPage.Text= dt.Rows[0][4].ToString();
        txtNameToAFriendLanded.Text = dt.Rows[0][5].ToString();
        AreaComment.InnerText = dt.Rows[0][6].ToString();
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        
        if (User.Identity.IsAuthenticated)
        {
            //Text Box
            txtGenre.Enabled = true;
            txtNumberOfPage.Enabled = true;
            txtNameToAFriendLanded.Enabled = true;
            AreaComment.Disabled = false;

            //Button
            btnUpload.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
        }
        else
        {
            Response.Redirect("~/Login.aspx");
        }



    }

    protected void btnUpload_Click(object sender, EventArgs e)
    {
        SqlConnection conn;
        SqlCommand comm;
        string connectionString = ConfigurationManager.ConnectionStrings["BOOKS"].ConnectionString;
        conn = new SqlConnection(connectionString);
        comm = new SqlCommand("UpdateBookDetails", conn);
        comm.CommandType = CommandType.StoredProcedure;
        comm.Parameters.AddWithValue("@ID", bookId);
        comm.Parameters.AddWithValue("@NewGenre", txtGenre.Text);
        comm.Parameters.AddWithValue("@NewNumberOfPage", txtNumberOfPage.Text);
        comm.Parameters.AddWithValue("@NewNameOfFriend", txtNameToAFriendLanded.Text);
        comm.Parameters.AddWithValue("@NewComment", AreaComment.InnerText);
        try
        {
            conn.Open();
            comm.ExecuteNonQuery();
        }
        finally
        {
            conn.Close();
        }
        btnDelete.Enabled = true;
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader reader;
        string connectionString = ConfigurationManager.ConnectionStrings["BOOKS"].ConnectionString;
        conn = new SqlConnection(connectionString);
        comm = new SqlCommand("DELETE FROM Books WHERE BookId = @BookId", conn);
        comm.Parameters.Add("BookId", SqlDbType.Int);
        comm.Parameters["BookId"].Value = bookId;
        try
        {
            conn.Open();
            reader = comm.ExecuteReader();
            reader.Close();
        }
        finally
        {
            conn.Close();
        }
        Response.Redirect("Book.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        btnDelete.Enabled = true;
    }
}
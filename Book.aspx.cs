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

public partial class Book : System.Web.UI.Page
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
            BindGrid();
        }
    }
    private void BindGrid()
    {
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader reader;
        string connectionString = ConfigurationManager.ConnectionStrings["BOOKS"].ConnectionString;
        conn = new SqlConnection(connectionString);
        comm = new SqlCommand("SELECT BookId, BookTitle, Author, ISBN " +
                            "FROM Books", conn);
        try
        {
            conn.Open();
            reader = comm.ExecuteReader();
            grid.DataSource = reader;
            grid.DataKeyNames = new string[] { "BookId" };
            grid.DataBind();
            reader.Close();
        }
        finally
        {
            conn.Close();
        }
    }

    protected void gird_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //Get the selected item of the index
        int index = Convert.ToInt32(e.CommandArgument);
        //Get the selected value
        GridViewRow row = grid.Rows[index];
        Response.Redirect("~/BookDetailspage.aspx?BookNum=" + row.Cells[0].Text);
    }



    //protected void bookDetails_ModeChanging(object sender, DetailsViewModeEventArgs e)
    //{
    //    bookDetails.ChangeMode(e.NewMode);
    //    BindDetails();
    //}

    //protected void grid_SelectedIndexChanged1(object sender, EventArgs e)
    //{
    //    BindDetails();
    //}

    //private void BindDetails()
    //{
    //    int selectedRowIndex = grid.SelectedIndex;
    //    int bookId = (int)grid.DataKeys[selectedRowIndex].Value;
    //    SqlConnection conn;
    //    SqlCommand comm;
    //    SqlDataReader reader;
    //    string connectionString = ConfigurationManager.ConnectionStrings["BOOKS"].ConnectionString;
    //    conn = new SqlConnection(connectionString);
    //    comm = new SqlCommand("SELECT BookId, Genre, NumberOfPage, LandedToAFriend, NameOfFriend, Comment " +
    //                          "FROM Books WHERE BookId = @BookId", conn);
    //    comm.Parameters.Add("BookId", SqlDbType.Int);
    //    comm.Parameters["BookId"].Value = bookId;
    //    try
    //    {
    //        conn.Open();
    //        reader = comm.ExecuteReader();
    //        bookDetails.DataSource = reader;
    //        bookDetails.DataKeyNames = new string[] { "BookId" };
    //        bookDetails.DataBind();
    //        reader.Close();
    //    }
    //    finally
    //    {
    //        conn.Close();
    //    }
    //}



    //protected void bookDetails_ItemDeleting(object sender, DetailsViewDeleteEventArgs e)
    //{
    //    int selectedRowIndex = grid.SelectedIndex;
    //    int bookId = (int)grid.DataKeys[selectedRowIndex].Value;
    //    SqlConnection conn;
    //    SqlCommand comm;
    //    SqlDataReader reader;
    //    string connectionString = ConfigurationManager.ConnectionStrings["BOOKS"].ConnectionString;
    //    conn = new SqlConnection(connectionString);
    //    comm = new SqlCommand("DELETE FROM Books WHERE BookId = @BookId", conn);
    //    comm.Parameters.Add("BookId", SqlDbType.Int);
    //    comm.Parameters["BookId"].Value = bookId;
    //    try
    //    {
    //        conn.Open();
    //        reader = comm.ExecuteReader();
    //        bookDetails.DataSource = reader;
    //        bookDetails.DataKeyNames = new string[] { "BookId" };
    //        bookDetails.DataBind();
    //        reader.Close();
    //    }
    //    finally
    //    {
    //        conn.Close();
    //    }
    //    Response.Redirect("Book.aspx");
    //}
    //protected void bookDetails_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
    //{
    //    int bookId = (int)bookDetails.DataKey.Value;
    //    TextBox newGenreTextBox = (TextBox)bookDetails.FindControl("editGenreTextBox");
    //    TextBox newNumberOfPageTextBox = (TextBox)bookDetails.FindControl("editNumberOfPageTextBox");
    //    TextBox newLandedToAFriendTextBox = (TextBox)bookDetails.FindControl("editlandedToAFriendTextBox");
    //    TextBox newNameOfFriendTextBox = (TextBox)bookDetails.FindControl("editnameOfFriendTextBox");
    //    TextBox newCommentTextBox = (TextBox)bookDetails.FindControl("editCommentTextBox");
    //    string newGenre = newGenreTextBox.Text;
    //    string newNumberOfPage = newNumberOfPageTextBox.Text;
    //    string newLandedToAFriend = newLandedToAFriendTextBox.Text;
    //    string newNameOfFriend = newNameOfFriendTextBox.Text;
    //    string newComment = newCommentTextBox.Text;

    //    SqlConnection conn;
    //    SqlCommand comm;
    //    string connectionString = ConfigurationManager.ConnectionStrings["BOOKS"].ConnectionString;
    //    conn = new SqlConnection(connectionString);
    //    comm = new SqlCommand("UpdateBookDetails", conn);
    //    comm.CommandType = CommandType.StoredProcedure;
    //    comm.Parameters.AddWithValue("@ID", bookId);
    //    comm.Parameters.AddWithValue("@NewGenre", newGenre);
    //    comm.Parameters.AddWithValue("@NewNumberOfPage", newNumberOfPage);
    //    comm.Parameters.AddWithValue("@NewLandedToAFriend", newLandedToAFriend);
    //    comm.Parameters.AddWithValue("@NewNameOfFriend", newNameOfFriend);
    //    comm.Parameters.AddWithValue("@NewComment", newComment);
    //    try
    //    {
    //        conn.Open();
    //        comm.ExecuteNonQuery();
    //    }
    //    finally
    //    {
    //        conn.Close();
    //    }
    //    bookDetails.ChangeMode(DetailsViewMode.ReadOnly);
    //    BindGrid();
    //    BindDetails();
    //}


}
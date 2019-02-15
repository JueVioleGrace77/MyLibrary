using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    public string BookTiTle
    {
        set { txtBookTitle.Text = value; }
        get { return txtBookTitle.Text; }
    }
    public string Author
    {
        set { txtAuthorName.Text = value; }
        get { return txtAuthorName.Text; }
    }
    public string ISBN
    {
        set { txtIsbnNumber.Text = value; }
        get { return txtIsbnNumber.Text; }
    }
    public bool EnabledTextBoxBookTitle
    {
        set { txtBookTitle.Enabled = value; }
        get { return txtBookTitle.Enabled; }
    }
    public bool EnabledTextAuthor
    {
        set { txtAuthorName.Enabled = value; }
        get { return txtAuthorName.Enabled; }
    }
    public bool EnabledTextBoxISBN
    {
        set { txtIsbnNumber.Enabled = value; }
        get { return txtIsbnNumber.Enabled; }
    }
}
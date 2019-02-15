using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Book
/// </summary>
public class Books
{
    public Books()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string BookTitle { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public string Genre { get; set; }
    public string NumberOfPage { get; set; }
    public string LandedToAFriend { get; set; }
    public string NameOfFriend { get; set; }
    public string Comment { get; set; }
}
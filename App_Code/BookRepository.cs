using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BookRepository
/// </summary>
public class BookRepository
{
    List<Books> BookList;
    public BookRepository()
    {
        //
        // TODO: Add constructor logic here
        //
        BookList = new List<Books>();
    }
    public List<Books> GetBook()
    {
        return BookList;
    }
    public void addBook(Books aBook)
    {
        BookList.Add(aBook);
    }
}
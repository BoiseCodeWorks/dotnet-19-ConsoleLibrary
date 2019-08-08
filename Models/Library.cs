using System.Collections.Generic;

namespace ConsoleLibrary.Models
{
  public class Library
  {
    //TODO Create the properties and methods that this class will need
    public List<Book> Books { get; set; }

    public void CheckOut()
    {

    }

    public void ViewBooks()
    {
      foreach (var book in Books)
      {

      }
    }
    public Library()
    {
      Books = new List<Book>();
    }
  }
}
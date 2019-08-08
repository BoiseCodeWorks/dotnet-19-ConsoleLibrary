using System.Collections.Generic;
using System;

namespace ConsoleLibrary.Models
{
  public class Library
  {
    //TODO Create the properties and methods that this class will need
    public List<Book> Books { get; set; }

    public void CheckOut()
    {
      Console.WriteLine("Which book number?: ");
      int index;
      bool isIndex = false;
      while (!isIndex)
      {
        isIndex = Int32.TryParse(Console.ReadLine(), out index);
      }

    }


    public void ViewBooks()
    {
      int bookCount = 1;
      foreach (var book in Books)
      {
        Console.WriteLine($"Book Count: {bookCount} Title: {book.Title} By: {book.Author}");
        bookCount++;
      }
    }
    public Library()
    {
      Books = new List<Book>();
    }
  }
}
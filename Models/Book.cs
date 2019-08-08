namespace ConsoleLibrary.Models
{
  public class Book
  {
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public bool Available { get; set; }
    public Book(string title, string author, int pages, bool available = true)
    {
      Title = title;
      Author = author;
      Pages = pages;
      Available = available;
    }
  }
}

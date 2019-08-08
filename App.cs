using ConsoleLibrary.Models;

namespace ConsoleLibrary
{
  public class App
  {
    private Library Library { get; set; }
    public void Setup()
    {
      //TODO create instances of some books

      Book hp = new Book("Harry Potter", "JK Rowling", 400);
      Book dune = new Book("Dune", "Frank Hurbert", 300);
      Book patsy = new Book("Patsy", "Nicole Benn-Dennis", 250);

      //TODO add those books to your library
    }

    public void Run()
    {
      //TODO write our application
      //1. we need a greeting and menu navigation
      //2. must be able to view, checkout, and return books
      //[STRETCH GOAL] allow the user to create instances of books 
    }

    // NOTE Our constructor method runs when an instance of an App is created and the logic within assigns a new instance of a Library to the property Library on our app
    public App()
    {
      Library = new Library();
    }
  }
}
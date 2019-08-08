using System;
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
      Library.Books.Add(hp);
      Library.Books.Add(dune);
      Library.Books.Add(patsy);
    }

    public void Run()
    {
      //TODO write our application
      Console.WriteLine("Welcome to the Library!");
      //1. we need a greeting and menu navigation
      bool inLibrary = true;
      while (inLibrary)
      {
        DisplayMenu();


      }
      //2. must be able to view, checkout, and return books
      //[STRETCH GOAL] allow the user to create instances of books 
    }
    public void DisplayMenu()
    {
      Console.WriteLine("1. View books");
      Console.WriteLine("2. Return a book");
      Console.WriteLine("3. Leave the library");
      Console.WriteLine("Please enter a number");
      HandleUserInput();
    }

    public void HandleUserInput()
    {
      string userInput = Console.ReadLine();
      switch (userInput)
      {
        case "1":
          Library.ViewBooks();
          break;
      }
    }

    // NOTE Our constructor method runs when an instance of an App is created and the logic within assigns a new instance of a Library to the property Library on our app
    public App()
    {
      Library = new Library();
    }
  }
}
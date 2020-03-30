using System;

namespace MyApp {
  class Program {
    static void Main (string[] args) {
      //---------------Hello World
      // string firstName ="Joca";
      // string secondName = "Doido";
      // Console.WriteLine($"Hello World {firstName} {secondName}");

      //----------------Methods Examples
      // string greeting = "      Hello World!       ";
      // Console.WriteLine ($"[{greeting}]");

      // string trimmedGreeting = greeting.TrimStart ();
      // Console.WriteLine ($"[{trimmedGreeting}]");

      // trimmedGreeting = greeting.TrimEnd ();
      // Console.WriteLine ($"[{trimmedGreeting}]");

      // trimmedGreeting = greeting.Trim ();
      // Console.WriteLine ($"[{trimmedGreeting}]");

      // string sayHello="Hello World";
      // Console.WriteLine(sayHello);
      // sayHello=sayHello.Replace("Hello", "Greetings");
      // Console.WriteLine(sayHello);

      string songLyrics = "You say goodbye, and I say hello";
      Console.WriteLine (songLyrics.Contains ("goodbye"));
      Console.WriteLine (songLyrics.Contains ("greetings"));

      Console.WriteLine (songLyrics.EndsWith ("hello"));
      Console.WriteLine (songLyrics.StartsWith ("greetings"));
    }
  }
}
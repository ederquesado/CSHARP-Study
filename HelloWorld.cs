using System;
using System.Collections.Generic;

namespace MyApp {
  class Program {
    static void Main (string[] args) {
      /*
      ---------------Hello World
      string firstName ="Joca";
      string secondName = "Doido";
      Console.WriteLine($"Hello World {firstName} {secondName}");

      ----------------Methods Examples
      string greeting = "      Hello World!       ";
      Console.WriteLine ($"[{greeting}]");

      string trimmedGreeting = greeting.TrimStart ();
      Console.WriteLine ($"[{trimmedGreeting}]");

      trimmedGreeting = greeting.TrimEnd ();
      Console.WriteLine ($"[{trimmedGreeting}]");

      trimmedGreeting = greeting.Trim ();
      Console.WriteLine ($"[{trimmedGreeting}]");

      string sayHello="Hello World";
      Console.WriteLine(sayHello);
      sayHello=sayHello.Replace("Hello", "Greetings");
      Console.WriteLine(sayHello);

      string songLyrics = "You say goodbye, and I say hello";
      Console.WriteLine (songLyrics.Contains ("goodbye"));
      Console.WriteLine (songLyrics.Contains ("greetings"));

      Console.WriteLine (songLyrics.EndsWith ("hello"));
      Console.WriteLine (songLyrics.StartsWith ("greetings"));

      if((songLyrics.Contains ("goodbye"))){
          Console.WriteLine ("Tem tetra ai");
      }
    -------- IF and Loops
      int sum = 0;
      for (int number = 1; number < 21; number++)
      {
        if (number % 3 == 0)
        {
          sum = sum + number;
        }
      }
      Console.WriteLine($"The sum is {sum}");
      ------- List  
      
      var names = new List<string> { "<name>", "joca", "neto" };
      foreach (var name in names) {
        Console.WriteLine ($"Hello {name.ToUpper()}!");
      }

      Console.WriteLine ("Fazendo modificações.......");
      names.Add ("Maria");
      names.Add ("Bill");
      names.Remove ("<name>");
      foreach (var name in names) {
        Console.WriteLine ($"Hello {name.ToUpper()}!");
      }
      Console.WriteLine ($"My name is {names[0]}.");
      Console.WriteLine ($"I've added {names[2]} and {names[3]} to the list.");
      Console.WriteLine (names.Count);

      var index = names.IndexOf ("anão");
      if (index != -1) {
        Console.WriteLine ($"The name {names[index]} is at index {index}");
      }
      var notFound = names.IndexOf ("Not Found");
      Console.WriteLine ($"When an item is not found, IndexOf returns {notFound}");

      names.Sort ();
      foreach (var name in names) {
        Console.WriteLine ($"Hello {name.ToUpper()}!");
      }
      */
      //Desafio Fibonacci
      var fibonacciNumbers = new List<int> { 1, 1 };

      while (fibonacciNumbers.Count < 20) {
        var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
        var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

        fibonacciNumbers.Add (previous + previous2);
      }
      foreach (var item in fibonacciNumbers)
        Console.WriteLine (item);
    }
  }
}
using System;

namespace DecisionMaking {
  class Program {
    static void Main(string[] args) {
      int a = 100;
      int b = 200;

      switch (a) {
        case 100:
        Console.WriteLine("Outer part of the switch statement.");

        switch (b) {
          case 200:
          Console.WriteLine("Inner part of the switch statement.");
          break;
        }
        break;
      }
      Console.WriteLine("Exact value is a is: {0}", a);
      Console.WriteLine("Exact value is b is: {0}", b);
      Console.ReadLine();
    }
  }
}
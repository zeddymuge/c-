using System;

namespace MyApplication
{
  class Car
  {
    string color = "dark-red";

    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine(myObj.color);
    }
  }
}

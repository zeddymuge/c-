using System;

namespace MyApplication
{
  class Program
  {
    static void MyMethod(string fname, int age)
    {
      Console.WriteLine(fname + " is " + age);
    }

    static void Main(string[] args)
    {
      MyMethod("Liam", 1);
      MyMethod("zed", 8);
      MyMethod("Anja", 3);
    }
  }
}

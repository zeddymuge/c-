using System;

namespace MyApplication
{
  class Animal
  {
    private string name;  // field
    public string Name    // property
    {
      get { return name; }
      set { name = value; }
    }  
  }
}

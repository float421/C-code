using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int x = 100;
    while (x > 1)
    {
      Console.Clear();
      Console.SetCursorPosition(x, 5);
      if(x % 3 == 0) Console.WriteLine("@__ ");
      else if(x % 3 == 1) Console.WriteLine("@^_");
      else Console.WriteLine("@_^");
      System.Threading.Thread.Sleep(150);
      x--;
    }
  }
}

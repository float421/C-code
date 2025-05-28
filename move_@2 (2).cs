using System;

class Program 
{
  public static void Main (string[] args) 
  {
    re:
    int x = 0, y = 0;
    ConsoleKeyInfo keyInfo = Console.ReadKey();
    bool state = true;
    while (state)
    {
      keyInfo = Console.ReadKey();
      Console.Clear();
      Console.SetCursorPosition(x, y);
      Console.Write("@");
      switch (keyInfo.Key)
      {
        case ConsoleKey.A:
          x--;
          break;
        case ConsoleKey.D:
          x++;
          break;
        case ConsoleKey.W:
          y--;
          break;
        case ConsoleKey.S:
          y++;
          break;
        case ConsoleKey.Escape:
          state = false;
          break;
      }
    }
    goto re;
  }
}
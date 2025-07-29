using System;
namespace idk;

class Program
{ 

   public static void Main()
    {
        Console.WriteLine(ReducedAnd(false, true));
        // Console.WriteLine("Hello, World!");
        // bool left = true;
        // bool right = false;
        // bool result = ReducedAnd(left, right);
        // Console.WriteLine($"ReducedAnd({left}, {right}) = {result}");
    }
    public static bool ReducedAnd(bool left, bool right) =>
  (left, right) switch
  {
      (true, true) => true,
      (_, _) => false,
  };
}
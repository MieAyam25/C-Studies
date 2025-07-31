using System;
using System.Collections.Generic;
using System.Dynamic;
namespace idk
{
    class Program
    {
        public static void Main()
        {
            List<int> fwaeh = new List<int> { };
            bool con2 = true;
            do
            {
                Console.Write("How much you want to add? ");
                string num = Console.ReadLine();
                int.TryParse(num, out int count);
                if (count <= 0)
                {
                    Console.WriteLine("Invalid count, must be greater than 0.");
                    return;
                }

                else
                {
                    Console.WriteLine($"You want to add {count} integers.");
                }

                for (int i = 0; i < count; i++)
                {
                    string op = Console.ReadLine();
                    if (int.TryParse(op, out int number))
                    {
                        fwaeh.Add(number);
                    }
                }
                con2 = false;

                Console.Write("add more (1), display (2): ");
                string con = Console.ReadLine();
                int.TryParse(con, out int con1);

                if (con1 == 2)
                {
                    fwaeh.Sort();
                    foreach (int i in fwaeh)
                        Console.WriteLine(i);
                }
                else if (con1 == 1)
                {
                    con2 = true;
                }
            }
            while (con2 == true);

            //     string[] amay = new string[2];
            //     amay[0] = "Hello";
            //     amay[1] = "World";
            //     foreach (string? s in amay)
            //         Console.WriteLine(amay == null ? "Array is null" : s);
        }
        // public static bool ReducedAnd(bool left, bool right) =>
        //    (left, right) switch
        //    {
        //        (true, true) => true,
        //        (_, _) => false,
        //    };

    }
}

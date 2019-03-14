using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int input = 0;
            if (args.Length > 0) {
                input = Int32.Parse(args[0]);
                Console.WriteLine(string.Format("Lists Fibonacci sequence values beginning at 0 and proceeding to, but not past, the target value: {0}", input));
                Console.WriteLine();

                fibonacci(input);
            } else {
                Console.WriteLine("No target value specified... Please try again, providing a whole number (integer) as the command argument.\n");
            }

            void fibonacci(int max)
            {
                int x = 0;
                int y = 1;

                if (max < 0) {
                    Console.WriteLine("Operating in Negative mode.\n");

                    while ((0 - Math.Abs(x)) >= max) {
                        Console.WriteLine(x);

                        int z = x;  //Keep track of last value
                        x = y - z;  //Subtract next value from last value
                        y = z;      //Restore saved last value
                    }
                } else if (max > 0) {
                    Console.WriteLine("Operating in Positive mode.\n");

                    while (x <= max) {
                        Console.WriteLine(x);

                        int z = x;  //Keep track of last value
                        x = z + y;  //Add last value to next value
                        y = z;      //Restore saved last value
                    }
                }

                Console.WriteLine();
            }

        }
    }
}

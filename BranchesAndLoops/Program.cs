using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = 5;
            int b = 6;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");


            int a2 = 5;
            int b2 = 3;
            if (a2 + b2 > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else if (a2 + b2 == 10)
            {
                Console.WriteLine("The answer is 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }



            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }


            // do-while läuft min. 1 mal
            int counter2 = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter2}");
                counter2++;
            } while (counter2 < 10);


            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }


            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }

        }
    }
}

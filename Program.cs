/* 
Author: Roberto Wong Hernandez
Date: 01/30/2023
Description: Building a C# console application to highlight all numbers in a even or odd series between 0 and the number chosen by the user but no more than 100
*/

namespace ISM_4300_Third_Deliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string series = "";


            try
            {


                while (true)
                {
                    Console.Write("Enter an integer between 0 and 100: ");
                    input = int.Parse(Console.ReadLine());

                    if (input >= 1 && input <= 100)
                    {
                        break;
                    }
                }

                while (true)
                {
                    Console.Write("Choose one of the series type Odd or Even: ");
                    series = Console.ReadLine();

                    if (series == "Even" || series == "Odd")
                    {
                        break;
                    }
                }


                if (series == "Even")
                {
                    Console.WriteLine("You have selected the " + series + " series. The even numbers between 0 and " + input + " are:");

                    for (int i = 0; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }

                if (series == "Odd")
                {
                    Console.WriteLine("You have selected the " + series + " series. The even numbers between 0 and " + input + " are:");

                    for (int i = 1; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            catch
            {
                Console.WriteLine("Please enter an integer between 1 and 100");
            }






        }
    }
}
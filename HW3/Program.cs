using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////HW3 TASK "A"___________________________c___________________________________________________________________

            //Console.WriteLine("Please enter the text.");
            //int totalChar = 0;
            //string text = Console.ReadLine();
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == 'a' || text[i] == 'o' || text[i] == 'i' || text[i] == 'e')
            //    {
            //        totalChar++;
            //    }
            //}
            //Console.WriteLine("The count of 'a', 'e', 'i', 'o' in the text = " + totalChar);

            //Console.WriteLine("\nPress any button to exit.");
            //Console.ReadKey();

            ////HW3 TASK "B"______________________________________________________________________________________________
            ////1)

            //Console.WriteLine("Enter year (e.g.2018)");
            //int year = Convert.ToInt32 (Console.ReadLine());
            //Console.WriteLine("Enter month (e.g.02)");
            //int month =Convert.ToInt32(Console.ReadLine());
            //int days = DateTime.DaysInMonth(year, month);
            //Console.WriteLine($"\n{month}.{year} had {days} days.");

            //Console.WriteLine("\nPress any button to exit.");
            //Console.ReadKey();

            ////2)потрібно через масиви

            //Console.WriteLine("Enter month (e.g.02)");
            //bool checkMonth = int.TryParse(Console.ReadLine(), out int month);
            //if(checkMonth = true)
            //{
            //    if ((month == 01) || (month == 03) || (month == 05) || (month == 07) || (month == 08) || (month == 10))
            //        Console.WriteLine($"The amount of days in the {month} month is 31");
            //    else if (month == 02)
            //        Console.WriteLine($"The amount of days in the {month} month is 28 or 29");
            //    else if ((month == 4) || (month == 6) || (month == 9) || (month == 11))
            //        Console.WriteLine($"The amount of days in the {month} month is 30");
            //    else
            //        Console.WriteLine($"Please enter the right data");
            //}

            //Console.WriteLine("\nPress any button to exit.");
            //Console.ReadKey();

            ////HW3 TASK "C"______________________________________________________________________________________________
            ////у другій частині потрібно не список а перемножити

            //Console.WriteLine("Please enter 10 integer numbers.");
            //int[] numbers = new int[10];
            //int sum = 0;
            //bool checkN1 = Int32.TryParse(Console.ReadLine(), out numbers[0]);
            //bool checkN2 = Int32.TryParse(Console.ReadLine(), out numbers[1]);
            //bool checkN3 = Int32.TryParse(Console.ReadLine(), out numbers[2]);
            //bool checkN4 = Int32.TryParse(Console.ReadLine(), out numbers[3]);
            //bool checkN5 = Int32.TryParse(Console.ReadLine(), out numbers[4]);
            //bool checkN6 = Int32.TryParse(Console.ReadLine(), out numbers[5]);
            //bool checkN7 = Int32.TryParse(Console.ReadLine(), out numbers[6]);
            //bool checkN8 = Int32.TryParse(Console.ReadLine(), out numbers[7]);
            //bool checkN9 = Int32.TryParse(Console.ReadLine(), out numbers[8]);
            //bool checkN10 = Int32.TryParse(Console.ReadLine(), out numbers[9]);
            //Console.WriteLine("----------------------------------------------------------");

            //if(checkN1 && checkN2 && checkN3 && checkN4 && checkN5 && 
            //    checkN6 && checkN7 && checkN8 && checkN9 && checkN10)
            //{
            //    if (numbers[0] > 0 && numbers[1] > 0 && numbers[2] > 0 && numbers[3] > 0 && numbers[4] > 0)
            //    {
            //        for (int i = 0; i < 5; i++)
            //            sum += numbers[i];
            //        Console.WriteLine($"The sum of the first five numbers is {sum}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Product of last 5 elements:\n");
            //        for (int i=5; i<numbers.Length;i++)
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //else
            //    Console.WriteLine("\nYou have entered not integer value.Check please and try again.");
            
            //Console.WriteLine("\nPress any button to exit.");
            //Console.ReadKey();
        }
    }
}

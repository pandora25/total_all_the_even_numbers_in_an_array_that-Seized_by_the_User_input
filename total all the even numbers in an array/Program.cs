using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace total_all_the_even_numbers_in_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] ArrayNums = { 2, 4, 6, 1, 6, 3, 8, 9, 10 };

            Console.Write("what is the sizxe of the array to be ?: ");

            int size = int.Parse(Console.ReadLine());

            List<int> ArrayNums = new List<int>();

            Console.WriteLine("now please enter the numbers you want to add ");
            int count = 0;

            for (int i = 0; i < size; i++)
            {
                count++;
                Console.WriteLine($"please enter#: {count}");
                int inpuToList = int.Parse(Console.ReadLine());
                ArrayNums.Add(inpuToList);
            }

            long sum = TotalAllEvenInts(ArrayNums);

            Console.WriteLine($"the Total is: {sum}");
        }

        public static long TotalAllEvenInts(List<int> intArray)
        {
            //return (from i in intArray where i % 2 == 0 select (int)i).Sum();

            long sum = 0;

            foreach (var item in intArray)
            {
                if (intArray[item] % 2 == 0)
                {
                    sum += item;
                }
                else
                {
                    Console.WriteLine($"{item} is Odd numebr");
                }
            }
            return sum;
        }
    }
}

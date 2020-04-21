using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] wowchars = new string [5]{"Arthas", "Guldan", "Ilidan", "Sylvanas", "Garosh"};

            Console.WriteLine("Print array using loop");
            Console.WriteLine(" ");

            for (int i = 0; i < wowchars.Length; i++)
            {
                Console.WriteLine(wowchars[i]);
            }
            Console.ReadLine();

            Console.WriteLine("Print int array backwards");
            Console.WriteLine(" ");

            // Please note that array size has been set to 21 instead of asked 20 in order to acomodate numbers from 0 to 20

            int[] numbers = new int[21]{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

            Array.Reverse(numbers);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

        }
    }
}
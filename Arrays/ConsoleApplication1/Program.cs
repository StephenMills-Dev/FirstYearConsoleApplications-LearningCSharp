using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int[] ArrayInt = {1,2,3,4,5,6,7,8,9};
        static void Main(string[] args)
        {
            //int largest = ChooseLargest(ArrayInt);
            //Console.WriteLine(largest);
            //int smallest = ChooseSmallest(ArrayInt);
            //Console.WriteLine(smallest);
            /*
            bool assending = ArraySorted(ArrayInt);
            if (assending)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            */
            double avarageOfEveryThiredElement = ArrayThiredAvarage(ArrayInt);
            Console.WriteLine(avarageOfEveryThiredElement);
        }
        static int ChooseLargest(int[] ArrayInt)
        {
            int largest = 0;
            for (int i = 0; i < ArrayInt.Length; i++)
            {
                if (ArrayInt[i] > largest)
                {
                    largest = ArrayInt[i];
                }
            }
            return largest;
        }
        static int ChooseSmallest(int[] ArrayInt)
        {
            int smallest = ArrayInt[7];
            for (int i = 0; i < ArrayInt.Length; i++)
            {
                if (ArrayInt[i] < smallest)
                {
                    smallest = ArrayInt[i];
                }
            }
            return smallest;
        }
        static bool ArraySorted(int[] ArrayInt)
        {
            bool assending = true;
            for (int i = 0; i < ArrayInt.Length-1; i++)
            {
                if (ArrayInt[i] > ArrayInt[i+1])
                {
                    assending = false;
                }
            }
            return assending;
        }
        static double ArrayThiredAvarage(int[] ArrayInt)
        {
            double total = 0;
            int count = 0;
            for (int i = 0; i < ArrayInt.Length; i+=2)
            {
                total += ArrayInt[i];
                count++;
            }
            double avarage = total / count;
            return total;
        }
    }
}

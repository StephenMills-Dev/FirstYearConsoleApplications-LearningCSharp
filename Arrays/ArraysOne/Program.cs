using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysOne
{
    class Program
    {
        static int[] playerAges = new int[6];
        static void Main(string[] args)
        {
            FillArray();
            //PrintArray();
            //PrintArrayFTL();
            //PrintArrayForEach();
            //PringReversArray();
            //double arrayAvarage = GetArrayAvarage();
            ReverseArray();
            PrintArray();
        }
        // question one
        static void FillArray()
        {
            for (int i = 0; i < playerAges.Length; i++)
            {
                Console.Write("Please enter the players age : ");
                playerAges[i] = int.Parse(Console.ReadLine());
            }
        }
        // question two
        static void PrintArray()
        {
            // printing each element of the array
            for (int i = 0; i < playerAges.Length; i++)
            {
                Console.WriteLine(playerAges[i]);
            }
        }
        // question three
        static void PrintArrayFTL()
        {
            // printing the first, Thired and last element
            for (int i = 0; i < playerAges.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(playerAges[i]);
                }
                else if (i == 2)
                {
                    Console.WriteLine(playerAges[i]);
                }
                else if (i == 5)
                {
                    Console.WriteLine(playerAges[i]);
                }
            }
        }
        // question four
        static void PrintArrayForEach()
        {
            // foreach to print out the elements of an array.
            foreach (var Age in playerAges)
            {
                Console.WriteLine(Age);
            }
        }
        // queston five
        static void PringReversArray()
        {
            for (int i = playerAges.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(playerAges[i]);
            }
        }
        // question six
        static double GetArrayAvarage()
        {
            double total = 0;
            for (int i = 0; i < playerAges.Length; i++)
            {
                total += playerAges[i];
            }
            return total / playerAges.Length;
        }
        // question seven
        static bool SearchArray()
        {
            bool result = false;
            int index = 0;
            Console.Write("Please enter the number you wish to search for : ");
            int search = int.Parse(Console.ReadLine());
            // repeats while result is false and we have not reached the end of the array.
            while (result == false && index < playerAges.Length)
            {
                // think of index like i in a for loop.
                if (playerAges[index] == search)
                {
                    result = true;
                }
                index++;
            }
            return result;
        }
        // question eight
        static void ReverseArray()
        {
            Array.Reverse(playerAges);
        }

    }
}

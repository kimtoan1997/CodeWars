using System.Collections.Generic;
using System.Linq;
namespace CodeWarChallence
{
    public class Program
    {
        static void Main(string[] agrs)
        {
            //Console.WriteLine("Hello");
            //MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });

            //Console.WriteLine(findNb(4183059834009));
            Console.WriteLine(OddOrEven(new int[]{0, 1, 4}));
        }
        public static int[] MoveZeroes(int[] arr)
        {
            // TODO: Program me
            /*
                Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
                Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
             */

            // C1
            //List<int> listZero = arr.Where(x => x == 0).ToList();

            //List<int> listWithoutZero = arr.Where(x => x != 0).ToList();
            //listZero.ForEach(x => listWithoutZero.Add(x));
            //return listWithoutZero.ToArray();

            // c2
            //var c  = arr.OrderBy(x => x == 0).ToArray();
            //return arr.OrderBy(x => x == 0).ToArray();

            // c3
            return arr.Where(x => x != 0).Concat(arr.Where(x => x == 0)).ToArray();

        }

        public static int CountBits(int n)
        {
            /*
                Write a function that takes an integer as input, and returns the number of bits that are equal to one in the binary representation of that number. You can guarantee that input is non-negative.

                Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case
             */

            //// C1
            if (n <= 0) return -1;
            //BitArray array = new BitArray(new int[] {n});
            //int count = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    count += array[i] == true ? 1 : 0;
            //}

            //return count;
            var x = Convert.ToString(n, 2);
            return Convert.ToString(n, 2).Count(x => x == '1');
        }

        public static long findNb(long m)
        {
            /*
                Your task is to construct a building which will be a pile of n cubes. The cube at the bottom will have a volume of n^3, the cube above will have volume of (n-1)^3 and so on until the top which will have a volume of 1^3.

                You are given the total volume m of the building. Being given m can you find the number n of cubes you will have to build?

                The parameter of the function findNb (find_nb, find-nb, findNb, ...) will be an integer m and you have to return the integer n such as n^3 + (n-1)^3 + ... + 1^3 = m if such a n exists or -1 if there is no such n.

                Examples:
                findNb(1071225) --> 45

                findNb(91716553919377) --> -1
             */
            // your code
            long total = 1, i = 2;
            for (; total < m; i++) total += i * i * i;
            return total == m ? i - 1 : -1;
        }

        public static string OddOrEven(int[] array)
        {
            /*
                Task:
                Given a list of integers, determine whether the sum of its elements is odd or even.

                Give your answer as a string matching "odd" or "even".

                If the input array is empty consider it as: [0] (array with a zero).
             */
            //enter code here
            //if (array.Length == 1 && array[0] == 0) return "even";
            //int count = 0;
            //array.ToList().ForEach(x => count += x);

            //return (count % 2) == 0 ? "even" : "odd";

            return array.Sum() % 2 == 0 ? "even" : "odd";
        }
    }
}
using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int MaximumDiscount(int N, int[] price)
        {
            int sum = 0;

            if (N != price.Length)
            {
                Console.WriteLine("intial condition is not correct");
                return -1;
            }

            foreach (int t in price)
            {
                if (t < 0)
                {
                    Console.WriteLine("intial condition is not correct");
                    return -1;
                }
            }

            Array.Sort(price);
            Array.Reverse(price);
            for (int i = 2; i < price.Length; i = i + 3)
            {
                sum = sum + price[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] price = { 400, 350 };
            int sum = MaximumDiscount(price.Length, price);
            foreach (int t in price) Console.Write(t + " ");
            Console.WriteLine();
            Console.WriteLine(sum);
            //Array.Sort(price);
            //foreach (int t in price) Console.Write(t+ " ");
            //Array.Reverse(price);
            //Console.WriteLine();
            //foreach (int t in price) Console.Write(t+ " ");
            //Console.WriteLine();
            //for (int i = 2; i < price.Length; i = i + 3)
            //{
            //    sum = sum + price[i];
            //}
            //Console.WriteLine(sum);


        }
    }
}

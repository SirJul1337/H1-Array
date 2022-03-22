using System;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int [9];
           

         
            for (int i = 0; i < array1.Length; i++)
            {
                array1 [i] = (i + 1);
                if (i == 5)
                {
                    array1[i] = i * 2;
                }
            }
            Console.WriteLine(array1[5]);
         
        }
    }
}

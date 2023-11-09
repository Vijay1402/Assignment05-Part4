using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment05_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int sum = 0;
            float avg = 0;
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(50);
            }
            for (int i = 0;i < arr.Length;i++) 
            {
                Console.WriteLine(arr[i]);
                sum += arr[i];
            }
            avg =  sum / arr.Length;
            Console.WriteLine("The sum of the elements in the array = "+sum);
            Console.WriteLine("The avearage of the elements in the array = " + avg);
            Console.ReadKey();
        }
    }
}

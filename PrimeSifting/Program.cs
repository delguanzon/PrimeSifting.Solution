using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrimeSifting.Models;

namespace PrimeSifting
{
    public class Program
    {
        public static void Main() 
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            PrimeSieve prime = new PrimeSieve(num);
            string primeNumbers = String.Join(" ,", prime.RemovePrimeMultiples());
            Console.WriteLine("These are the Prime Numbers: {0}", primeNumbers);

        }
    }
}
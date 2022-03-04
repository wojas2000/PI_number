using System;

namespace PI_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program show number PI with 5 number after point
            double PI;
            Console.WriteLine("Program podaje liczbę PI z dokładnością pieciu miejsc po przecinku.");
            PI = Math.PI;   
            Console.WriteLine($"Całkowita wartość liczby PI:" + PI);
            Console.WriteLine("Liczba PI z dokładnością do pięciu miejsc po przecinku: " + PI);
            Console.WriteLine(Convert.ToString(PI));
        }
    }
}

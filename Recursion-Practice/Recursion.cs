using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion_Practice
{
    class Recursion
    {
        public static int Summation(int n)
        {
            int sum = 0;
            if(n < 1)
            {
                Console.WriteLine("Numero incorrecto");
                return 0;
            }
            if (n == 1)
            {
                return n;
            }
            else
            {
                sum = n + Summation(n - 1);
                return sum;
            }
        }
        public static int SummationDigits(int n)
        {
            int sum = 0;
            if(n == 0)
            {
                return 0;
            }
            else
            {
                sum = SummationDigits(n / 10) + n % 10;

                return sum;
            }
        }
  public static string PrimeNumber(int n)
        {

            if (n >= 2)
            {
                int i = n / 2;

                bool prime = PrimeNumber(n, i);

                if (prime == true)
                {
                    return n + " es un numero primo";
                }
                else
                {
                    return n + " no es numero primo";
                }
            }
            return "debe ser un numero positivo mayor a 1";
        }
        public static bool PrimeNumber(int n, int i)
        {

            if (i == 1)
            {
                return true;
            }
            else
            {
                if(n % i == 0)
                {
                    return false;
                }
                else 
                {
                    i = i - 1;
                    return PrimeNumber(n,i);
                }
            }
        }

        public static int Spiderman(int bul)
        {
            if (bul <= 1)
            {
                return 1;
            }
            else
                return Spiderman(bul - 1) + Spiderman(bul - 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomLib.Theorem
{
    class Prime
    {
        /// <summary>
        /// check if the number is prime number
        /// </summary>
        /// <returns>true if the number is a prime number</returns>
        public bool CheckIfNumberIsPrime(int number)
        {
            var isPrime = true;

            try
            {
                for (var i = 2; i <= number / 2; i++)
                {
                    if (0 == number % i)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                isPrime = false;
            }
            return isPrime;
        }
    }
}

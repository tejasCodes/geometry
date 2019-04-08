using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomLib.Theorem
{
    class Armstrong
    {

        /// <summary>
        /// checks if the given number is a armstrong number
        /// </summary>
        /// <param name="number"></param>
        /// <returns>true if number is a armstrong number</returns>
        public bool CheckIfArmStrong(int number)
        {
            var isArmstrong = false;
            try
            {
                var temp = number;
                var newNumber = 0;
                while (0 != number)
                {
                    var n = number % 10;
                    newNumber += (int)Math.Pow(n, 3);
                    number /= 10;
                }
                isArmstrong = temp == newNumber ?  true : false;
            }
            catch (Exception)
            {
                isArmstrong = false;
            }
            return isArmstrong;
        }
    }
}



using System;

namespace FizzBuzzKataNameSpace
{
    public class FizzBuzzKata
    {
        public object[] getFizzBuzzKata(object[] arrayNumbers)
        {
            for(int i=0; i < arrayNumbers.Length; i++)
            {
                if (isDivisbleBy3(arrayNumbers[i]) && isDivisbleBy5(arrayNumbers[i]))
                {
                    arrayNumbers[i] = "FizzBuzz";

                }else if (isDivisbleBy5(arrayNumbers[i]))
                {
                    arrayNumbers[i] = "Buzz";
                }else if (isDivisbleBy3(arrayNumbers[i]))
                {
                    arrayNumbers[i] = "Fizz";
                }

            }
            return arrayNumbers;
        }

        private bool isDivisbleBy3(object number)
        {
            if (Convert.ToInt32(number) % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isDivisbleBy5(object number)
        {
            if (Convert.ToInt32(number) % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

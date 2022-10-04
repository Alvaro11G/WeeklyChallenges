using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                if(number % 2 == 0)
                {
                    sum += number;
                }

                if(number % 2 != 0)
                {
                    sum -= number;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int> {str1.Length, str2.Length, str3.Length, str4.Length};
            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            if (number2 >= number1 && number3 >= number1 && number4 >= number1)
            {
                return number1;
            }
            else if (number1 >= number2 && number3 >= number2 && number4 >= number2)
            {
                return number2;
            }
            else if (number1 >= number3 && number2 >= number3 && number4 >= number3)
            {
                return number3;
            }
            else
            {
                return number4;
            }
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return
                (
                sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1
                );
        }

        public bool IsStringANumber(string input)
        {
            bool isNumber = double.TryParse(input, out double number);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var majority = (amount / 2) + 1;
            var count = 0;

            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    count++;
                }
            }

            if(count >= majority)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }

            double sum = 0;
            var count = 0;
            foreach(var number in numbers)
            {
                if(number % 2 == 0)
                {
                    sum += number;
                    count++;
                }
            }
            if(count > 0)
            {
                return sum / count;
            }
            else
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            var fact = 1;

            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for(int i = number; i > 0; i--)
            {
                fact *= i;
            }
            return fact;
        }
    }
}

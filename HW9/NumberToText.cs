using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public class NumberToText
    {

        public string getResultTask6(int n)
        {
            string[] arr1 = new string[20] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] arr2 = new string[8] { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            string result = "";

            if (n > 0 && n < 20)
            {
                result = $"{arr1[n]}";
            }
            else if (n < 99)
            {
                if (n == 0)
                {
                    result = $"{arr1[n]}";
                }
                else if (n % 10 == 0)
                {
                    int a = n / 10;
                    result = $"{arr2[a - 2]}";
                }
                else
                {
                    int a = n % 10;
                    int b = n / 10;
                    result = $"{arr2[b - 2]}-{arr1[a]}";
                }
            }
            else if (n == 100 || n == 200 || n == 300 || n == 400 || n == 500 || n == 600 || n == 700 || n == 800 || n == 900)
            {
                n = n / 100;
                result = $"{arr1[n]} hundred";
            }
            else if (n % 100 < 20)
            {
                int a = n % 100;
                int b = n / 100;

                result = $"{arr1[b]} hundred and {arr1[a]}";
            }
            else
            {
                if (n % 10 == 0)
                {
                    int a = n / 100;
                    n = n / 10;
                    int b = n % 10;
                    result = $"{arr1[a]} hundred and {arr2[b - 2]}";
                }
                else
                {
                    int c = n % 10;
                    n = n / 10;
                    int b = n % 10;
                    int a = n / 10;

                    result = $"{arr1[a]} hundred and {arr2[b - 2]}-{arr1[c]}";
                }
            }


            return result;
        }

    }
}

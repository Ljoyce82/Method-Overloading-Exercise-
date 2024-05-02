using System.Diagnostics.CodeAnalysis;
using System.Security;

namespace MethodOverloading
{
    public class Program
    {   
        static void Main(string[] args)
        {
            var z = 34;
            var x = 44;
            int sumInt = Add(z, x);

            var a = 45.3m;
            var b = 87.1m;
            decimal sumDecimal = Add(a, b);

            var sumString = Add(3, -2, true);

            Console.WriteLine($"Int Add Method: {sumInt} double Add Method {sumDecimal}");
            Console.WriteLine(sumString);

            ;
        }
       static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        static string Add(int num1, int num2, bool IsCheck)
        {   
            var sum = num1 + num2;

            if (IsCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (IsCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (!IsCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }

        }

    }
}

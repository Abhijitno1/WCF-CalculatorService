using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelfHost = CalculatorServiceProxyClient.CalculatorServiceReference;
using WinSrv = CalculatorServiceProxyClient.CalculatorWinServiceReference;

namespace CalculatorServiceProxyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //SelfHostClientTest();
            WinServHostClientTest();
            Console.ReadKey();
        }

        static void SelfHostClientTest()
        {
            SelfHost.SimpleCalculatorClient client = new SelfHost.SimpleCalculatorClient("BasicHttpBinding_ISimpleCalculator");
            Console.Write("Enter first Number: ");
            var num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second Number: ");
            var num2 = Convert.ToDouble(Console.ReadLine());
            var sum = client.AddNumbers(num1, num2);
            Console.WriteLine("The sum is {0}", sum);
            var sub = client.SubtractNumbers(num1, num2);
            Console.WriteLine("The subtraction is {0}", sub);
            var mul = client.MultplyNumbers(num1, num2);
            Console.WriteLine("The multiplication is {0}", mul);
            var div = client.DivideNumbers(num1, num2);
            Console.WriteLine("The division is {0}", div);

            client.Close();
        }

        static void WinServHostClientTest()
        {
            WinSrv.SimpleCalculatorClient client = new WinSrv.SimpleCalculatorClient("BasicHttpBinding_ISimpleCalculator_WinSrv");
            Console.Write("Enter first Number: ");
            var num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second Number: ");
            var num2 = Convert.ToDouble(Console.ReadLine());
            var sum = client.AddNumbers(num1, num2);
            Console.WriteLine("The sum is {0}", sum);
            var sub = client.SubtractNumbers(num1, num2);
            Console.WriteLine("The subtraction is {0}", sub);
            var mul = client.MultplyNumbers(num1, num2);
            Console.WriteLine("The multiplication is {0}", mul);
            var div = client.DivideNumbers(num1, num2);
            Console.WriteLine("The division is {0}", div);

            client.Close();
        }
    }
}

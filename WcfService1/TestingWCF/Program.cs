using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingWCF.WCFTest;
namespace TestingWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient proxy = new CalculatorClient();
            double a= proxy.AddNumbers(3.2, 0.7);
        }
    }
}

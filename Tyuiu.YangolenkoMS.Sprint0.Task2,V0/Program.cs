using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.YangolenkoMS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.YangolenkoMS.Sprint0.Task2_V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(DataService.GetMessage("Матвей"));
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}

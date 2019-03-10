using System;

namespace FourthUnitTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            if (dmuka2.CS.UnitTest.IsUnitTest.Check)
                Console.WriteLine("Error!");
            else
                Console.WriteLine("Success.");

            Console.ReadKey(true);
        }
    }
}

using System;

namespace PrimitiveTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Types test = new Types();
            test.num1 = 3;
            bool result = test.num1.HasValue;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
    public class Types
    {
        public int? num1;
        public static Types Spaget => true;
    }
}

using SubModCommon;
using System;

namespace SubModProjectA
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = Enum.GetNames(typeof(TestEnum));
            foreach(var value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}

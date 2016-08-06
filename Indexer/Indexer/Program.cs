using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            BaseClass baseInstance = instance;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(baseInstance[i]);
            }
        }
    }
}

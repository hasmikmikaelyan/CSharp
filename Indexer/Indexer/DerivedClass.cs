using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class DerivedClass : BaseClass
    {
        private string[] derivedArray = null;

        public DerivedClass()
        {
            derivedArray = new string[2];
            derivedArray[0] = "Dog";
            derivedArray[1] = "Cat";
        }
        public override string this[int index]
        {
            get { return base[index] + " - " + derivedArray[index]; }
        }
    }
}

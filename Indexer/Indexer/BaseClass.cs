using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class BaseClass
    {
        private string[] baseArray = null;
        public BaseClass()
        {
            baseArray = new string[2];
            baseArray[0] = "Собака";
            baseArray[1] = "Кошка";
        }

        public virtual string this[int index]
        {
            get { return baseArray[index]; }
        }
    }
}

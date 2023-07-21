using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{

    public delegate T information<T>(T arg1);
    class Class1
    {
        public information<String> info;
    }
}

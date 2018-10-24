using Modifiers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viewer
{
    class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example();
            //OnlyInAssemblyDueToInternalModifier, it is not possible to access to it
            //Derived is internal by default, then it's not possible to access to it
        }
    }
}

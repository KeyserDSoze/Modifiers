using Modifiers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers.Viewer
{
    internal class Code : Example
    {
        public void Test()
        {
            string a = this.ProtectedField;
            string b = this.ProtectedInternalField;
            string c = this.PublicField;
        }
    }
}

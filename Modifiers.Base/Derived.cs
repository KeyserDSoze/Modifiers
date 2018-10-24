using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers.Base
{
    class Derived : OnlyInAssemblyDueToInternalModifier //it's internal by default
    {
        public void Test()
        {
            string a = this.InternalField;
            string b = this.PrivateProtectedField;
            string c = this.ProtectedField;
            string d = this.ProtectedInternalField;
            string e = this.PublicField;
        }
    }
}

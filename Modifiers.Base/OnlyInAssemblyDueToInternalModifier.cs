using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers.Base
{
    internal class OnlyInAssemblyDueToInternalModifier
    {
        public string PublicField;
        private string PrivateField;
        protected string ProtectedField;
        internal string InternalField;
        protected internal string ProtectedInternalField;
        private protected string PrivateProtectedField;
    }
}

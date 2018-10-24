using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers.Base
{
    public class Example
    {
        //protected OnlyInAssemblyDueToInternalModifier OnlyInAssemblyDueToInternalModifier; //Inconsistent accessibility
        //protected internal OnlyInAssemblyDueToInternalModifier OnlyInAssemblyDueToInternalModifier; //Inconsistent accessibility
        private OnlyInAssemblyDueToInternalModifier OnlyInAssemblyDueToInternalModifier;

        public string PublicField;
        private string PrivateField;
        protected string ProtectedField;
        internal string InternalField;
        protected internal string ProtectedInternalField;
        private protected string PrivateProtectedField;
        public Example()
        {
            this.OnlyInAssemblyDueToInternalModifier = new OnlyInAssemblyDueToInternalModifier();
            string a = this.OnlyInAssemblyDueToInternalModifier.InternalField;
            string b = this.OnlyInAssemblyDueToInternalModifier.ProtectedInternalField;
            string c = this.OnlyInAssemblyDueToInternalModifier.PublicField;
        }

        //Inconsistent accessibility in return
        //public OnlyInAssemblyDueToInternalModifier Get()
        //{
        //    return this.OnlyInAssemblyDueToInternalModifier;
        //}
    }
}

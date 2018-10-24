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
            //it's accessible by instance only public, internal and protected internal (cause it's a logic OR through protected and internal)
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

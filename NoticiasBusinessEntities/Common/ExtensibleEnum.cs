using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticiasBusinessEntities.Common
{
    public class ExtensibleEnum
    {
        private ExtensibleEnum() 
        {
            Value = -1;
        }

        protected ExtensibleEnum(int value) 
        {
            Value = value;
        }

        protected int Value { get; set; }

        protected int GetValue()
        {
            return Value;
        }
    }
}

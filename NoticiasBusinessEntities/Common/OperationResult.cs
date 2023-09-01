using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticiasBusinessEntities.Common
{
    public class OperationResult : ExtensibleEnum
    {
      
        public static readonly OperationResult Success = (OperationResult)0;
       
        private OperationResult() 
            : base(-1) 
        { }

        protected OperationResult(int value)
            : base(value)
        { }

        public static explicit operator OperationResult(int value)
        { 
            return new OperationResult(value); 
        }

        public override string ToString()
        {
            string result;
            switch (Value)
            {
                case 0:
                    result = "OperationResult.Success";
                    break;

                default:
                    result = "Unknown";
                    break;
            }

            return result;
        }
    }
}

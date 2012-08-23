/* _________________________________________________

  (c) Hi-Integrity Systems 2012. All rights reserved.
  www.hisystems.com.au - Toby Wicks
  github.com/hisystems/Interpreter
 ___________________________________________________ */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HiSystems.Interpreter
{
    /// <summary>
    /// Returns the modulus from two numeric values.
    /// </summary>
    public class ModulusOperator : Operator
    {
        public ModulusOperator()
        {
        }

        internal override Literal Execute(IConstruct argument1, IConstruct argument2)
        {
            return base.GetTransformedConstruct<Number>(argument1) % base.GetTransformedConstruct<Number>(argument2);
        }

        public override string Token
        {
            get 
            {
                return "%";
            }
        }
    }
}
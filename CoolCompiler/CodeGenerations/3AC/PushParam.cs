using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCompiler.CodeGenerations
{
    public class PushParam : ThreeCode
    {
        public int Variable;
        public PushParam(int variable)
        {
            Variable = variable;
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return "PushParam t" + Variable + ";";
        }
    }
}

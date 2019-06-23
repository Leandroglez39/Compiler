using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCompiler.CodeGenerations
{
    public class Return : ThreeCode
    {

        public int Variable { get; }

        public Return(int variable = -1)
        {
            Variable = variable;
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return "Return " + (Variable == -1 ? "" : "t" + Variable) + ";\n";
        }
    }
}

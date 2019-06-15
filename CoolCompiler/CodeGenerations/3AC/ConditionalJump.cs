using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolCompiler.CodeGenerations;

namespace CoolCompiler.CodeGenerations
{
    public class GotoJump : ThreeCode
    {
        public LabelLine Label;

        public GotoJump(LabelLine label)
        {
            Label = label;
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }


        public override string ToString()
        {
            return $"Goto {Label.Label}";
        }
    }

    public class ConditionalJump : ThreeCode
    {
        public LabelLine Label;
        public int ConditionalVar;
        public ConditionalJump(int conditional_var, LabelLine label)
        {
            Label = label;
            ConditionalVar = conditional_var;
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"IfZ t{ConditionalVar} Goto {Label.Label}";
        }
    }
}

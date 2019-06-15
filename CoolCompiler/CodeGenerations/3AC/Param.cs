using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCompiler.CodeGenerations
{
    public class Param : ThreeCode
    {
        public int VariableCounter;
        public Param(int variable_counter)
        {
            VariableCounter = variable_counter;
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return "PARAM t" + VariableCounter + ";";
        }
    }
}

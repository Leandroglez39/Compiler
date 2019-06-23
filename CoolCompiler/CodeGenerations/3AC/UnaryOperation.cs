using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCompiler.CodeGenerations
{
    public class UnaryOperation : ThreeCode
    {
        public int AssignVariable { get; }
        public int OperandVariable { get; }
        public string Symbol { get; }

        public UnaryOperation(int assign_variable, int operand, string symbol)
        {
            AssignVariable = assign_variable;
            OperandVariable = operand;
            Symbol = symbol;
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"t{AssignVariable} = {Symbol} t{OperandVariable}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCompiler.CodeGenerations
{
    public class BinaryOperation : ThreeCode
    {
        public int AssignVariable { get; }
        public int LeftOperandVariable { get; }
        public int RightOperandVariable { get; }
        public string Symbol { get; }

        public BinaryOperation(int assign_variable, int left_operand, int right_operand, string symbol)
        {
            AssignVariable = assign_variable;
            LeftOperandVariable = left_operand;
            RightOperandVariable = right_operand;
            Symbol = symbol;
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"t{AssignVariable} = t{LeftOperandVariable} {Symbol} t{RightOperandVariable}";
        }
    }
}

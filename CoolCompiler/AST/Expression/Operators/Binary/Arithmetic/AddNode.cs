using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;

namespace CoolCompiler.AST.Expression.Operators.Binary.Arithmetic
{
    public class AddNode : ArithmeticOperation
    {
        public override string Symbol => "+";

        public AddNode(ParserRuleContext context) : base(context)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
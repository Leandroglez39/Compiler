using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;

namespace CoolCompiler.AST.Expression.Operators.Binary.Arithmetic
{
    public class SubNode : ArithmeticOperation
    {
        public override string Symbol => "/";

        public SubNode(ParserRuleContext context) : base(context)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
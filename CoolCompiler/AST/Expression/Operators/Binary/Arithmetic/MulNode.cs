using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;


namespace CoolCompiler.AST.Expression.Operators.Binary.Arithmetic
{
    public class MulNode : ArithmeticOperation
    {
        public override string Symbol => "*";

        public MulNode(ParserRuleContext context) : base(context)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
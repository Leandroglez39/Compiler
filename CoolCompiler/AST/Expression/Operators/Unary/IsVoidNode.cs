using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;


namespace CoolCompiler.AST
{
    public class IsVoidNode : UnaryOperationNode
    {
        public override string Symbol => "isvoid";

        public IsVoidNode(ParserRuleContext context) : base(context)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
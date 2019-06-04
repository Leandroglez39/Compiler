using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;


namespace CoolCompiler.AST
{
    public class NegNode : UnaryOperationNode
    {
        public override string Symbol => "~";

        public NegNode(ParserRuleContext context) : base(context)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;

namespace CoolCompiler.AST
{
    public class NotNode :UnaryOperationNode
    {
        public override string Symbol => "not";

        public NotNode(ParserRuleContext context) : base(context)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

    }
}
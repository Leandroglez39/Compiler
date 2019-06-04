
using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;

namespace CoolCompiler.AST
{
    public class FormalNode : ExpressionNode
    {
        public IdentifierNode Id { get; set; }
        public TypeNode Type { get; set; }

        public FormalNode(ParserRuleContext context) : base(context)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
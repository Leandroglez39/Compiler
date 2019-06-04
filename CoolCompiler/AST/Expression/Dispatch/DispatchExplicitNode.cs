using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;


namespace CoolCompiler.AST.Expression
{
    public class DispatchExplicitNode : DispatchNode
    {
        public ExpressionNode Expression { get; set; }
        public TypeNode IdType { get; set; }

        public DispatchExplicitNode(ParserRuleContext context) : base(context)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

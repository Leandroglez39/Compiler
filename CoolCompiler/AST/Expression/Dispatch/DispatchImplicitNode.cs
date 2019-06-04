using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;



namespace CoolCompiler.AST
{
    public class DispatchImplicitNode : DispatchNode
    {
        public DispatchImplicitNode(ParserRuleContext context) : base(context)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

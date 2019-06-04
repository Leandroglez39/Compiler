using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;

namespace CoolCompiler.AST
{
    class SelfNode :AtomNode
    {
        public SelfNode(ParserRuleContext context) : base(context)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

using Antlr4.Runtime;

namespace CoolCompiler.AST
{
    public abstract class AtomNode : ExpressionNode
    {
        public AtomNode(ParserRuleContext context) : base(context)
        {
        }

        public AtomNode(int line, int column) : base(line, column)
        {
        }
    }
}
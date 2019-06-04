using Antlr4.Runtime;

namespace CoolCompiler.AST
{
    public abstract class KeywordNode : ExpressionNode
    {
        public KeywordNode(ParserRuleContext context) : base(context)
        {
        }
    }
}
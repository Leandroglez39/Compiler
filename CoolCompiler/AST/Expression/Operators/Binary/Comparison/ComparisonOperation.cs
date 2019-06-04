using Antlr4.Runtime;

namespace CoolCompiler.AST
{
    public abstract class ComparisonOperation : BinaryOperationNode
    {
        public ComparisonOperation(ParserRuleContext context) : base(context)
        {
        }
    }
}
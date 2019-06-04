using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;

namespace CoolCompiler.AST.Expression.Operators.Binary.Arithmetic
{
    public abstract class ArithmeticOperation :BinaryOperationNode
    {
        public ArithmeticOperation(ParserRuleContext context) : base(context)
        {
        }
    }
}
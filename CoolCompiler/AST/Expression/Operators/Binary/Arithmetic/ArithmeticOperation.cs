using Antlr4.Runtime;


namespace CoolCompiler.AST
{
    public abstract class ArithmeticOperation :BinaryOperationNode
    {
        public ArithmeticOperation(ParserRuleContext context) : base(context)
        {
        }
    }
}
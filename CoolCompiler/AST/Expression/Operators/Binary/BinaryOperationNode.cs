using System;
using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;

namespace CoolCompiler.AST.Expression.Operators.Binary
{
    public abstract class BinaryOperationNode :ExpressionNode
    {
        public ExpressionNode LeftOperand { get; set; }
        public ExpressionNode RightOperand { get; set; }

        public BinaryOperationNode(ParserRuleContext context) : base(context)
        {
        }

        public abstract string Symbol { get; }
    }
}
﻿using Antlr4.Runtime;

namespace CoolCompiler.AST
{
    public abstract class UnaryOperationNode : ExpressionNode
    {
        public ExpressionNode Operand { get; set; }

        public abstract string Symbol { get; }

        public UnaryOperationNode(ParserRuleContext context) : base(context)
        {
        }
    }
}
﻿using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;



namespace CoolCompiler.AST
{
    public class IfNode : KeywordNode
    {
        public ExpressionNode Condition { get; set; }
        public ExpressionNode Body { get; set; }
        public ExpressionNode ElseBody { get; set; }

        public IfNode(ParserRuleContext context) : base(context)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
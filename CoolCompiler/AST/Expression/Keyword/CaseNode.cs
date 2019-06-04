﻿using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;
using System.Collections.Generic;

namespace CoolCompiler.AST.Expression.Keyword
{
    public class CaseNode : KeywordNode
    {
        public ExpressionNode ExpressionCase { get; set; }
        public List<(FormalNode Formal, ExpressionNode Expression)> Branches { get; set; }
        public int BranchSelected { get; set; }

        public CaseNode(ParserRuleContext context) : base(context)
        {
            Branches = new List<(FormalNode, ExpressionNode)>();
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
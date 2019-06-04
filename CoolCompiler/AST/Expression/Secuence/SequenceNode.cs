using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;
using System.Collections.Generic;

namespace CoolCompiler.AST.Expression.Secuence
{
    public class SequenceNode :ExpressionNode
    {
        public List<ExpressionNode> Sequence { get; set; }

        public SequenceNode(ParserRuleContext context) : base(context)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
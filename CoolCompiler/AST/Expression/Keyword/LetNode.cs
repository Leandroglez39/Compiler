using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;
using System.Collections.Generic;



namespace CoolCompiler.AST.Expression.Keyword
{
    public class LetNode : KeywordNode
    {
        public List<AttributeNode> Initialization { get; set; }
        public ExpressionNode ExpressionBody { get; set; }

        public LetNode(ParserRuleContext context) : base(context)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
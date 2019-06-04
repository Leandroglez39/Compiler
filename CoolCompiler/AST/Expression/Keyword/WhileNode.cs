using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;


namespace CoolCompiler.AST.Expression.Keyword
{
    public class WhileNode :KeywordNode
    {
        public ExpressionNode Condition { get; set; }
        public ExpressionNode Body { get; set; }

        public WhileNode(ParserRuleContext context) : base(context)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
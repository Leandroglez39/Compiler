using Antlr4.Runtime;

using CoolCompiler.SemanticCheck;


namespace CoolCompiler.AST
{
    public abstract class AttributeNode :FeatureNode 
    {
        public FormalNode Formal { get; set; }
        public ExpressionNode AssignExp { get; set; }

        public AttributeNode(ParserRuleContext context) : base(context)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;


namespace CoolCompiler.AST
{
    public class NewNode : KeywordNode
    {
        public TypeNode TypeId { get; set; }

        public NewNode(ParserRuleContext context) : base(context)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
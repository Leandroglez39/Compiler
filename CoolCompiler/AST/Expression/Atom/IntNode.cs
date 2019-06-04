using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;


namespace CoolCompiler.AST
{
    public class IntNode :AtomNode
    {
        public int Value { get; set; }

        public IntNode(ParserRuleContext context, string text) : base(context)
        {
            Value = int.Parse(text);
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
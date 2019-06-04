using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;

namespace CoolCompiler.AST.Expression
{
    public class BoolNode :AtomNode
    {
        public bool Value { get; set; }

        public BoolNode(ParserRuleContext context, string text) : base(context)
        {
            Value = bool.Parse(text);
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
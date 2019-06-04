using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;


namespace CoolCompiler.AST.Expression.Atom
{
    public class VoidNode : AtomNode
    {
        public string GetStaticType { get; }
        public VoidNode(string type, int line = 0, int column = 0) : base(line, column)
        {
            GetStaticType = type;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
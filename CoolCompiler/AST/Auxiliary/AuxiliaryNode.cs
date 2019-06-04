using Antlr4.Runtime;

namespace CoolCompiler.AST
{
    public abstract class AuxiliaryNode : ASTNode
    {
        public AuxiliaryNode(ParserRuleContext context) : base(context) { }

        public AuxiliaryNode(int line, int column) : base(line, column) { }
    }
}
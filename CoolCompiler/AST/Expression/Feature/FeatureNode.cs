using CoolCompiler.SemanticCheck;
using Antlr4.Runtime;

namespace CoolCompiler.AST
{
    public abstract class FeatureNode : ASTNode , IVisit
    {
        public FeatureNode(ParserRuleContext context) : base(context) { }

        public abstract void Accept(IVisitor visitor);

    }
}
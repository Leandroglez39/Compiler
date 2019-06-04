using CoolCompiler.SemanticCheck;
using System.Collections.Generic;
using Antlr4.Runtime;
using CoolCompiler.SemanticCheck.Info;

namespace CoolCompiler.AST.Expression
{
    public abstract class ExpressionNode : ASTNode, IVisit
    {
        public TypeInfo StaticType = TypeInfo.OBJECT;

        public ExpressionNode(ParserRuleContext context) : base(context) { }

        public ExpressionNode(int line, int column) : base(line, column) { }

        public abstract void Accept(IVisitor visitor);
    }
}
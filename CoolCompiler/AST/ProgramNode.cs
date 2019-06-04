using CoolCompiler.SemanticCheck;
using Antlr4.Runtime;
using System.Collections.Generic;



namespace CoolCompiler.AST
{
    public abstract class ProgramNode : ASTNode, IVisit
    {
        public List<ClassNode> Classes { get; set; }

        public ProgramNode(ParserRuleContext context) : base(context)
        {
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
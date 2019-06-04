using Antlr4.Runtime;
using System.Collections.Generic;
using CoolCompiler.SemanticCheck;

namespace CoolCompiler.AST
{
    public class MethodNode : FeatureNode
    {
        public IdNode Id { get; set; }
        public List<FormalNode> Arguments { get; set; }
        public TypeNode TypeReturn { get; set; }
        public ExpressionNode Body { get; set; }

        public MethodNode(ParserRuleContext context) : base(context)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
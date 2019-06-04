
using Antlr4.Runtime;
using System.Collections.Generic;

namespace CoolCompiler.AST.Expression
{
    public abstract class DispatchNode : ExpressionNode
    {
        public IdNode IdMethod { get; set; }

        public List<ExpressionNode> Arguments { get; set; }

        public DispatchNode(ParserRuleContext context) : base(context)
        {

        }
    }
}
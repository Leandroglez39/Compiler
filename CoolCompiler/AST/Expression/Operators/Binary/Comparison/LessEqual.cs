using CoolCompiler.SemanticCheck;
using Antlr4.Runtime;

namespace CoolCompiler.AST
{
    
        public class LessEqual : ComparisonOperation
        {
            public override string Symbol => "<=";

            public LessEqual(ParserRuleContext context) : base(context)
            {
            }

            public override void Accept(IVisitor visitor)
            {
                visitor.Visit(this);
            }
        }
}
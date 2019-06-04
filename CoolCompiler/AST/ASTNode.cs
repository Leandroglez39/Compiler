using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;

namespace CoolCompiler.AST
{
    public abstract class ASTNode
    {
        public int Line { get; }

        public int Column { get; }

        public Dictionary<string, dynamic> Attributes { get; }

        public ASTNode(ParserRuleContext context)
        {
            Line = context.Start.Line;
            Column = context.Start.Column + 1;
            Attributes = new Dictionary<string, dynamic>();
        }

        public ASTNode(int line, int column)
        {
            Line = line;
            Column = column;
        }
    }
}

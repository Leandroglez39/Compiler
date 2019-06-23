using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCompiler.CodeGenerations
{
    public class CommentLine : ThreeCode
    {
        string Comment { get; }
        public CommentLine(string comment)
        {
            Comment = comment;
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return "// " + Comment;
        }
    }
}

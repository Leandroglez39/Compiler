using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCompiler.CodeGenerations
{
    public class Inherit : ThreeCode
    {
        public string Child;
        public string Parent;


        public Inherit(string child, string parent)
        {
            Child = child;
            Parent = parent;
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"_class.{Child}: _class.{Parent}";
        }
    }
}

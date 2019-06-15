using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCompiler.CodeGenerations
{
    public class PopParam : ThreeCode
    {
        int Times;
        public PopParam(int times)
        {
            Times = times;
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"PopParam {Times};";
        }
    }
}

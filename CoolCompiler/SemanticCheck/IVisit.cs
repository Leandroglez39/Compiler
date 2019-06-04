using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCompiler.SemanticCheck
{
    public interface IVisit
    {
        void Accept(IVisitor visitor);
    }
}
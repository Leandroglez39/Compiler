using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolCompiler.CodeGenerations;

namespace CoolCompiler.CodeGenerations
{
    public abstract class Assignment<T> : ThreeCode
    {
        public int Left { get; protected set; }
        public T Right { get; protected set; }

    }

    public class AssignmentVariableToMemory : Assignment<int>
    {
        public int Offset { get; }
        public AssignmentVariableToMemory(int left, int right, int offset = 0)
        {
            Left = left;
            Right = right;
            Offset = offset;
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"*(t{Left} + {Offset}) = t{Right}";
        }
    }

    public class AssignmentVariableToVariable : Assignment<int>
    {
        public AssignmentVariableToVariable(int left, int right)
        {
            Left = left;
            Right = right;
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"t{Left} = t{Right}";
        }
    }

    public class AssignmentConstantToMemory : Assignment<int>
    {
        public int Offset { get; }
        public AssignmentConstantToMemory(int left, int right, int offset = 0)
        {
            Left = left;
            Right = right;
            Offset = offset;
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"*(t{Left} + {Offset}) = {Right}";
        }
    }

    public class AssignmentMemoryToVariable : Assignment<int>
    {
        public int Offset { get; }

        public AssignmentMemoryToVariable(int left, int right, int offset = 0)
        {
            Left = left;
            Right = right;
            Offset = offset;
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"t{Left} = *(t{Right} + {Offset})"; ;
        }
    }


    public class AssignmentConstantToVariable : Assignment<int>
    {

        public AssignmentConstantToVariable(int left, int right)
        {
            Left = left;
            Right = right;
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"t{Left} = {Right}";
        }
    }

    public class AssignmentStringToVariable : Assignment<string>
    {

        public AssignmentStringToVariable(int left, string right)
        {
            Left = left;
            Right = right;
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"t{Left} = \"{Right}\"";
        }
    }

    public class AssignmentStringToMemory : Assignment<string>
    {
        public int Offset { get; }
        public AssignmentStringToMemory(int left, string right, int offset = 0)
        {
            Left = left;
            Right = right;
            Offset = offset;
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"*(t{Left} + {Offset}) = \"{Right}\"";
        }
    }


    public class AssignmentLabelToVariable : Assignment<LabelLine>
    {
        public AssignmentLabelToVariable(int left, LabelLine right)
        {
            Left = left;
            Right = right;
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"t{Left} = \"{Right.Label}\"";
        }
    }

    public class AssignmentLabelToMemory : Assignment<LabelLine>
    {
        public int Offset { get; }
        public AssignmentLabelToMemory(int left, LabelLine right, int offset)
        {
            Left = left;
            Right = right;
            Offset = offset;
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"*(t{Left} + {Offset}) = Label \"{Right.Label}\"";
        }
    }

    public class AssignmentNullToVariable : ThreeCode
    {
        public int Variable { get; }

        public AssignmentNullToVariable(int variable)
        {
            Variable = variable;
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }


        public override string ToString()
        {
            return $"t{Variable} = NULL;";
        }
    }
}

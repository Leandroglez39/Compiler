

namespace CoolCompiler.CodeGenerations
{
    public class CallLabel : ThreeCode
    {
        public LabelLine Method { get; }
        public int Result { get; }
        public CallLabel(LabelLine method, int result_variable = -1)
        {
            Method = method;
            Result = result_variable;
        }

        public override string ToString()
        {
            if (Result == -1)
                return $"Call {Method.Label};";
            else
                return $"t{Result} = Call {Method.Label};";
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class CallAddress : ThreeCode
    {
        public int Address { get; }
        public int Result { get; }
        public CallAddress(int address, int result_variable = -1)
        {
            Address = address;
            Result = result_variable;
        }

        public override string ToString()
        {
            if (Result == -1)
                return $"Call t{Address};";
            else
                return $"t{Result} = Call t{Address};";
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

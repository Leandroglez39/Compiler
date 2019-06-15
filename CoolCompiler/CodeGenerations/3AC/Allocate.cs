namespace CoolCompiler.CodeGenerations
{
    public class Allocate : ThreeCode
    {
        public int Variable { get; }
        public int Size { get; }

        public Allocate(int variable, int size)
        {
            Variable = variable;
            Size = size;
        }

        public override void Accept(ICodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"t{Variable} = Alloc {Size};";
        }
    }
}
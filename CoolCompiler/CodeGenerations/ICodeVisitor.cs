using CoolCompiler.CodeGenerations;


namespace CoolCompiler.CodeGenerations
{
    public interface ICodeVisitor
    {
        
        void Visit(Allocate line);
        
        void Visit(AssignmentVariableToMemory line);

        void Visit(AssignmentVariableToVariable line);

        void Visit(AssignmentConstantToMemory line);

        void Visit(AssignmentMemoryToVariable line);

        void Visit(AssignmentConstantToVariable line);

        void Visit(AssignmentStringToVariable line);

        void Visit(AssignmentStringToMemory line);

        void Visit(AssignmentLabelToVariable line);

        void Visit(AssignmentLabelToMemory line);
        
        void Visit(CallLabel line);

        void Visit(CallAddress line);
        
        void Visit(CommentLine line);
        
        void Visit(GotoJump line);

        void Visit(ConditionalJump line);
        
        void Visit(LabelLine line);
        
        void Visit(AssignmentNullToVariable line);
        
        void Visit(BinaryOperationLine line);

        void Visit(UnaryOperationLine line);
        
        void Visit(Param line);

        void Visit(PopParam line);
        
        void Visit(PushParam line);

        void Visit(Return line);
        void Visit(Inherit line);
    }
}
using CoolCompiler.CodeGenerations;


namespace CoolCompiler.CodeGenerations
{
    public interface ICodeVisitor
    {
        /*
        void Visit(AllocateLine line);
        */
        void Visit(AssignmentVariableToMemory line);

        void Visit(AssignmentVariableToVariable line);

        void Visit(AssignmentConstantToMemory line);

        void Visit(AssignmentMemoryToVariable line);

        void Visit(AssignmentConstantToVariable line);

        void Visit(AssignmentStringToVariable line);

        void Visit(AssignmentStringToMemory line);

        void Visit(AssignmentLabelToVariable line);

        void Visit(AssignmentLabelToMemory line);
        /*
        void Visit(CallLabelLine line);

        void Visit(CallAddressLine line);

        void Visit(CommentLine line);
        */
        void Visit(GotoJump line);

        void Visit(ConditionalJump line);
        
        void Visit(LabelLine line);
        
        void Visit(AssignmentNullToVariable line);
        /*
        void Visit(BinaryOperationLine line);

        void Visit(UnaryOperationLine line);
        */
        void Visit(Param line);

        void Visit(PopParam line);
        /*
        void Visit(PushParamLine line);

        void Visit(ReturnLine line);
        void Visit(InheritLine line);*/
    }
}
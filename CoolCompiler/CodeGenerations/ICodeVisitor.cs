﻿using CoolCompiler.CodeGenerations;

namespace CoolCompiler.CodeGenerations
{
    public interface ICodeVisitor
    {
        /*
        void Visit(AllocateLine line);

        void Visit(AssignmentVariableToMemoryLine line);

        void Visit(AssignmentVariableToVariableLine line);

        void Visit(AssignmentConstantToMemoryLine line);

        void Visit(AssignmentMemoryToVariableLine line);

        void Visit(AssignmentConstantToVariableLine line);

        void Visit(AssignmentStringToVariableLine line);

        void Visit(AssignmentStringToMemoryLine line);

        void Visit(AssignmentLabelToVariableLine line);

        void Visit(AssignmentLabelToMemoryLine line);
        
        void Visit(CallLabelLine line);

        void Visit(CallAddressLine line);

        void Visit(CommentLine line);

        void Visit(GotoJumpLine line);

        void Visit(ConditionalJumpLine line);
        */
        void Visit(LabelLine line);
        /*
        void Visit(AssignmentNullToVariableLine line);

        void Visit(BinaryOperationLine line);

        void Visit(UnaryOperationLine line);

        void Visit(ParamLine line);

        void Visit(PopParamLine line);

        void Visit(PushParamLine line);

        void Visit(ReturnLine line);
        void Visit(InheritLine line);*/
    }
}
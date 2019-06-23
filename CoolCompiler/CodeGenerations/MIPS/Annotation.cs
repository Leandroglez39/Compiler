using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolCompiler.SemanticCheck;
using CoolCompiler.CodeGenerations;

namespace CoolCompiler.CodeGenerations
{
    public class Annotation : ICodeVisitor
    {
        public Dictionary<string, int> FunctionVarsSize;
        public Dictionary<string, (int, int)> FunctionLimits;
        public Dictionary<string, int> FunctionParamsCount;
        public Dictionary<string, int> StringsCounter;
        public Dictionary<string, string> Inherit;

        int current_line;
        string current_function;
        int string_counter;

        public Annotation(List<ThreeCode> lines)
        {
            FunctionVarsSize = new Dictionary<string, int>();
            FunctionLimits = new Dictionary<string, (int, int)>();
            FunctionParamsCount = new Dictionary<string, int>();
            StringsCounter = new Dictionary<string, int>();
            Inherit = new Dictionary<string, string>();
            string_counter = 0;

            for (current_line = 0; current_line < lines.Count; ++current_line)
            {
                lines[current_line].Accept(this);
            }
        }

        public void Visit(LabelLine line)
        {
            if (line.Head[0] != '_')
            {
                current_function = line.Label;
                FunctionVarsSize[current_function] = 0;
                FunctionLimits[current_function] = (current_line, -1);
                FunctionParamsCount[current_function] = 0;
            }
        }

        public void Visit(Allocate line)
        {
            FunctionVarsSize[current_function] = Math.Max(FunctionVarsSize[current_function], line.Variable + 1);
        }

        public void Visit(AssignmentVariableToVariable line)
        {
            FunctionVarsSize[current_function] = Math.Max(FunctionVarsSize[current_function], line.Left + 1);
        }

        public void Visit(AssignmentMemoryToVariable line)
        {
            FunctionVarsSize[current_function] = Math.Max(FunctionVarsSize[current_function], line.Left + 1);
        }

        public void Visit(AssignmentConstantToVariable line)
        {
            FunctionVarsSize[current_function] = Math.Max(FunctionVarsSize[current_function], line.Left + 1);
        }

        public void Visit(AssignmentStringToVariable line)
        {
            FunctionVarsSize[current_function] = Math.Max(FunctionVarsSize[current_function], line.Left + 1);
            if (!StringsCounter.ContainsKey(line.Right))
            {
                StringsCounter[line.Right] = string_counter++;
            }

        }

        public void Visit(AssignmentLabelToVariable line)
        {
            FunctionVarsSize[current_function] = Math.Max(FunctionVarsSize[current_function], line.Left + 1);
        }

        public void Visit(BinaryOperation line)
        {
            FunctionVarsSize[current_function] = Math.Max(FunctionVarsSize[current_function], line.AssignVariable + 1);
        }

        public void Visit(UnaryOperation line)
        {
            FunctionVarsSize[current_function] = Math.Max(FunctionVarsSize[current_function], line.AssignVariable + 1);
        }

        public void Visit(Param line)
        {
            FunctionVarsSize[current_function] = Math.Max(FunctionVarsSize[current_function], line.VariableCounter + 1);
            ++FunctionParamsCount[current_function];
        }

        public void Visit(Return line)
        {
            FunctionLimits[current_function] = (FunctionLimits[current_function].Item1, current_line);
        }

        public void Visit(AssignmentStringToMemory line)
        {
            if (!StringsCounter.ContainsKey(line.Right))
            {
                StringsCounter[line.Right] = string_counter++;
            }
        }

        public void Visit(Inherit line)
        {
            Inherit[line.Child] = line.Parent;

            if (!StringsCounter.ContainsKey(line.Child))
                StringsCounter[line.Child] = string_counter++;
            if (!StringsCounter.ContainsKey(line.Parent))
                StringsCounter[line.Parent] = string_counter++;
        }

        public void Visit(AssignmentVariableToMemory line)
        {
            return;
            throw new NotImplementedException();
        }

        public void Visit(AssignmentConstantToMemory line)
        {
            return;
            throw new NotImplementedException();
        }

        
        public void Visit(AssignmentLabelToMemory line)
        {
            return;
            throw new NotImplementedException();
        }

        public void Visit(CallLabel line)
        {
            return;
            throw new NotImplementedException();
        }

        public void Visit(CallAddress line)
        {
            return;
            throw new NotImplementedException();
        }

        public void Visit(CommentLine line)
        {
            return;
            throw new NotImplementedException();
        }

        public void Visit(GotoJump line)
        {
            return;
            throw new NotImplementedException();
        }

        public void Visit(ConditionalJump line)
        {
            return;
            throw new NotImplementedException();
        }


        public void Visit(AssignmentNullToVariable line)
        {
            return;
            throw new NotImplementedException();
        }

        public void Visit(PopParam line)
        {
            return;
            throw new NotImplementedException();
        }

        public void Visit(PushParam line)
        {
            return;
            throw new NotImplementedException();
        }
        
    }
}

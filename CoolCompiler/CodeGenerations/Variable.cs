﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCompiler.CodeGenerations
{
    public class VariableManager
    {

        Stack<int> variable_counter_stack;
        public int VariableCounter { set; get; }

        public string CurrentClass { set; get; }

        Dictionary<string, Stack<(int, string)>> VariableLink;

        public VariableManager()
        {
            VariableCounter = 0;
            VariableLink = new Dictionary<string, Stack<(int, string)>>();
            variable_counter_stack = new Stack<int>();
        }

        public void PushVariable(string name, string type)
        {
            if (!VariableLink.ContainsKey(name))
                VariableLink[name] = new Stack<(int, string)>();

            VariableLink[name].Push((VariableCounter, type));
        }

        public void PopVariable(string name)
        {
            if (VariableLink.ContainsKey(name) && VariableLink[name].Count > 0)
                VariableLink[name].Pop();
        }

        public (int, string) GetVariable(string name)
        {
            if (VariableLink.ContainsKey(name) && VariableLink[name].Count > 0)
                return VariableLink[name].Peek();
            else
                return (-1, "");
        }

        public void PushVariableCounter()
        {
            variable_counter_stack.Push(VariableCounter);
        }

        public int PeekVariableCounter()
        {
            return variable_counter_stack.Peek();
        }

        public void PopVariableCounter()
        {
            VariableCounter = variable_counter_stack.Pop();
        }

        public int IncrementVariableCounter()
        {
            ++VariableCounter;
            return VariableCounter;
        }
    }
}

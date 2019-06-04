﻿using CoolCompiler.SemanticCheck;
using System.Collections.Generic;
using Antlr4.Runtime;

namespace CoolCompiler.AST
{
    public class ClassNode :ASTNode,IVisit
    {
        public TypeNode TypeClass { get; set; }

        public TypeNode TypeInherit { get; set; }

        public List<FeatureNode> FeatureNodes { get; set; }

        public IScope Scope { get; set; }

        public ClassNode(ParserRuleContext context) : base(context)
        {
        }

        public ClassNode(int line, int column, string className, string classInherit) : base(line, column)
        {
            TypeClass = new TypeNode(line, column, className);
            TypeInherit = new TypeNode(line, column, classInherit);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
﻿using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;



namespace CoolCompiler.AST.Expression.Atom
{
    public class StringNode : AtomNode
    {
        public string Text { get; set; }

        public StringNode(ParserRuleContext context, string text) : base(context)
        {
            Text = "";

            // 0 to Length - 1 in order to remove the (Antlr delivered) ""
            for (int i = 1; i < text.Length - 1; ++i)
            {
                Text += text[i];
            }

            //Text = text;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
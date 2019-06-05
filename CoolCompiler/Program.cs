using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using CoolCompiler.SemanticCheck;
using CoolCompiler.AST;
using Antlr4.Runtime.Tree;
using CoolCompiler.ANTLR;


namespace CoolCompiler
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = new AntlrFileStream("C:/Users/Leandro/Desktop/Compiler/CoolCompiler/input.cl");
            var lexer = new CoolLexer(input);

            var errors = new List<string>();
            lexer.RemoveErrorListeners();
            

            var tokens = new CommonTokenStream(lexer);

            var parser = new CoolParser(tokens);

            Console.WriteLine( parser.program().ToStringTree(parser) );
            Console.WriteLine(  );

        }
    }
}

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

            var tree = parser.program();

            ASTBuilder astBuilder = new ASTBuilder();
            ASTNode ast = astBuilder.Visit(tree);
            Console.WriteLine( );


           /* var a = new Dictionary<int,int>();
            a.Add(1,2);
            a.Add(3, 4);
            a.Add(5, 6);

            foreach (var x in ast.Attributes)
            {
                Console.WriteLine( "{"+ 
                x.Key.ToString() + ":" + x.Value.ToString() + "}" );
            }
            */
            
            Console.WriteLine( tree.ToStringTree(parser) );

        }
    }
}

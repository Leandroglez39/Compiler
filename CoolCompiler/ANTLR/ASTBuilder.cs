using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using CoolCompiler.AST;
using System.Linq;
using System;

namespace CoolCompiler.ANTLR
{
    public class ASTBuilder : CoolBaseVisitor<ASTNode>
    {
        protected override ASTNode DefaultResult => base.DefaultResult;

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override ASTNode Visit(IParseTree tree)
        {
            return base.Visit(tree);
        }

        public override ASTNode VisitArithmetic([NotNull] CoolParser.ArithmeticContext context)
        {
            ArithmeticOperation operators;

            switch (context.op.Text)
            {
                case "*":
                    operators = new MulNode(context);
                    break;
                case "/":
                    operators = new DivNode(context);
                    break;
                case "+":
                    operators = new AddNode(context);
                    break;
                case "-":
                    operators = new SubNode(context);
                    break;
                default:
                    throw new NotSupportedException();
            }

            operators.LeftOperand = Visit(context.expression(0)) as ExpressionNode;      // LEFT EXPRESSION
            operators.RightOperand = Visit(context.expression(1)) as ExpressionNode;     //RIGHT EXPRESSION

            return operators;
        }

        public override ASTNode VisitAssignment([NotNull] CoolParser.AssignmentContext context)
        {
            return new AssignmentNode(context)
            {
                ID = new IdentifierNode(context, context.ID().GetText()),
                ExpressionRight = Visit(context.expression()) as ExpressionNode
            };
        }

        public override ASTNode VisitBlock([NotNull] CoolParser.BlockContext context)
        {
            return new SequenceNode(context)
            {
                Sequence = context.expression().Select(x => Visit(x) as ExpressionNode).ToList()
            };
        }

        public override ASTNode VisitBoolean([NotNull] CoolParser.BooleanContext context)
        {
            return new BoolNode(context, context.value.Text);
        }

        public override ASTNode VisitBoolNot([NotNull] CoolParser.BoolNotContext context)
        {
            return new NotNode(context)
            {
                Operand = Visit(context.expression()) as ExpressionNode
            };
        }

        public override ASTNode VisitCase([NotNull] CoolParser.CaseContext context)
        {
            CaseNode node = new CaseNode(context)
            {
                ExpressionCase = Visit(context.expression(0)) as ExpressionNode
            };

            var formals = context.formal().Select(x => Visit(x)).ToList();
            var expressions = context.expression().Skip(1).Select(x => Visit(x)).ToList();
            for (int i = 0; i < formals.Count; ++i)
                node.Branches.Add((formals[i] as FormalNode, expressions[i] as ExpressionNode));

            return node;
        }


        //Terminar de ser necesario
        public override ASTNode VisitChildren(IRuleNode node)
        {
            return base.VisitChildren(node);
        }

        public override ASTNode VisitClassDefine([NotNull] CoolParser.ClassDefineContext context)
        {
            ClassNode node = new ClassNode(context);
            TypeNode typeClass = new TypeNode(context.TYPE(0).Symbol.Line, context.TYPE(0).Symbol.Column, context.TYPE(0).GetText());
            var typeInherit = context.TYPE(1) == null ? TypeNode.OBJECT : new TypeNode(context.TYPE(1).Symbol.Line,
                context.TYPE(1).Symbol.Column, context.TYPE(1).GetText());

            node.TypeClass = typeClass;
            node.TypeInherit = typeInherit;
            node.FeatureNodes = (from x in context.feature() select Visit(x) as FeatureNode).ToList();

            return node;
        }

        public override ASTNode VisitComparisson([NotNull] CoolParser.ComparissonContext context)
        {
            ComparisonOperation operators;
            switch (context.op.Text)
            {
                case "<=":
                    operators = new LessEqual(context);
                    break;
                case "<":
                    operators = new Less(context);
                    break;
                case "=":
                    operators = new EqualNode(context);
                    break;
                default:
                    throw new NotSupportedException();
            }


            operators.LeftOperand = Visit(context.expression(0)) as ExpressionNode;      // LEFT EXPRESSION
            operators.RightOperand = Visit(context.expression(1)) as ExpressionNode;     //RIGHT EXPRESSION
            return operators;
        }

        public override ASTNode VisitDispatchExplicit([NotNull] CoolParser.DispatchExplicitContext context)
        {
            DispatchExplicitNode node = new DispatchExplicitNode(context)
            {
                Expression = Visit(context.expression(0)) as ExpressionNode
            };

            var typeSuperClass = context.TYPE() == null ? new TypeNode(node.Expression.Line, node.Expression.Column, node.Expression.StaticType.Text) :
                new TypeNode(context.TYPE().Symbol.Line, context.TYPE().Symbol.Column, context.TYPE().GetText());
            node.IdType = typeSuperClass;

            IdNode idNode = new IdNode(context.ID().Symbol.Line, context.ID().Symbol.Column, context.ID().GetText());
            node.IdMethod = idNode;

            node.Arguments = (from x in context.expression().Skip(1) select Visit(x) as ExpressionNode).ToList();
            return node;
        }

        public override ASTNode VisitDispatchImplicit([NotNull] CoolParser.DispatchImplicitContext context)
        {
            return new DispatchImplicitNode(context)
            {
                IdMethod = new IdNode(context, context.ID().GetText()),
                Arguments = (from x in context.expression() select Visit(x) as ExpressionNode).ToList()
            };
        }


        //Terminar en caso de ser Necesario
        public override ASTNode VisitErrorNode(IErrorNode node)
        {
            return base.VisitErrorNode(node);
        }
        //Mirar mas adelante
        public override ASTNode VisitFeature([NotNull] CoolParser.FeatureContext context)
        {
            return base.VisitFeature(context);
        }

        public override ASTNode VisitFormal([NotNull] CoolParser.FormalContext context)
        {
            return new FormalNode(context)
            {
                Id = new IdentifierNode(context, context.ID().GetText()),
                Type = new TypeNode(context.TYPE().Symbol.Line, context.TYPE().Symbol.Column, context.TYPE().GetText())
            };
        }

        public override ASTNode VisitId([NotNull] CoolParser.IdContext context)
        {
            if (context.ID().GetText() == "self")
                return new SelfNode(context);
            return new IdentifierNode(context, context.ID().GetText());
        }

        public override ASTNode VisitIf([NotNull] CoolParser.IfContext context)
        {
            return new IfNode(context)
            {
                Condition = Visit(context.expression(0)) as ExpressionNode,   //  if expression
                Body = Visit(context.expression(1)) as ExpressionNode,   //then expression
                ElseBody = Visit(context.expression(2)) as ExpressionNode    //else expression
            };
        }

        public override ASTNode VisitInt([NotNull] CoolParser.IntContext context)
        {
            return new IntNode(context, context.INT().GetText());
        }

        public override ASTNode VisitIsvoid([NotNull] CoolParser.IsvoidContext context)
        {
            return new IsVoidNode(context)
            {
                Operand = Visit(context.expression()) as ExpressionNode
            };
        }

        public override ASTNode VisitLetIn([NotNull] CoolParser.LetInContext context)
        {
            LetNode node = new LetNode(context)
            {
                Initialization = (from x in context.property() select Visit(x) as AttributeNode).ToList(),
                ExpressionBody = Visit(context.expression()) as ExpressionNode
            };
            return node;
        }

        public override ASTNode VisitMethod([NotNull] CoolParser.MethodContext context)
        {
            MethodNode node = new MethodNode(context);

            IdNode idMethod = new IdNode(context, context.ID().GetText());
            node.Id = idMethod;

            node.Arguments = (from x in context.formal() select Visit(x) as FormalNode).ToList();

            var typeReturn = new TypeNode(context.TYPE().Symbol.Line, context.TYPE().Symbol.Column, context.TYPE().GetText());
            node.TypeReturn = typeReturn;

            node.Body = Visit(context.expression()) as ExpressionNode;
            return node;
        }

        public override ASTNode VisitNegative([NotNull] CoolParser.NegativeContext context)
        {
            return new NegNode(context)
            {
                Operand = Visit(context.expression()) as ExpressionNode
            };
        }

        public override ASTNode VisitNew([NotNull] CoolParser.NewContext context)
        {
            return base.VisitNew(context);
        }

        public override ASTNode VisitParentheses([NotNull] CoolParser.ParenthesesContext context)
        {
            return base.VisitParentheses(context);
        }

        public override ASTNode VisitProgram([NotNull] CoolParser.ProgramContext context)
        {
            return base.VisitProgram(context);
        }

        public override ASTNode VisitProperty([NotNull] CoolParser.PropertyContext context)
        {
            return base.VisitProperty(context);
        }

        public override ASTNode VisitString([NotNull] CoolParser.StringContext context)
        {
            return base.VisitString(context);
        }

        public override ASTNode VisitTerminal(ITerminalNode node)
        {
            return base.VisitTerminal(node);
        }

        public override ASTNode VisitWhile([NotNull] CoolParser.WhileContext context)
        {
            return base.VisitWhile(context);
        }

        protected override ASTNode AggregateResult(ASTNode aggregate, ASTNode nextResult)
        {
            return base.AggregateResult(aggregate, nextResult);
        }

        protected override bool ShouldVisitNextChild(IRuleNode node, ASTNode currentResult)
        {
            return base.ShouldVisitNextChild(node, currentResult);
        }
    }
}
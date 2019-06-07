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

        public override ASTNode VisitChildren(IRuleNode node)
        {
            return base.VisitChildren(node);
        }

        public override ASTNode VisitClassDefine([NotNull] CoolParser.ClassDefineContext context)
        {
            return base.VisitClassDefine(context);
        }

        public override ASTNode VisitComparisson([NotNull] CoolParser.ComparissonContext context)
        {
            return base.VisitComparisson(context);
        }

        public override ASTNode VisitDispatchExplicit([NotNull] CoolParser.DispatchExplicitContext context)
        {
            return base.VisitDispatchExplicit(context);
        }

        public override ASTNode VisitDispatchImplicit([NotNull] CoolParser.DispatchImplicitContext context)
        {
            return base.VisitDispatchImplicit(context);
        }

        public override ASTNode VisitErrorNode(IErrorNode node)
        {
            return base.VisitErrorNode(node);
        }

        public override ASTNode VisitFeature([NotNull] CoolParser.FeatureContext context)
        {
            return base.VisitFeature(context);
        }

        public override ASTNode VisitFormal([NotNull] CoolParser.FormalContext context)
        {
            return base.VisitFormal(context);
        }

        public override ASTNode VisitId([NotNull] CoolParser.IdContext context)
        {
            return base.VisitId(context);
        }

        public override ASTNode VisitIf([NotNull] CoolParser.IfContext context)
        {
            return base.VisitIf(context);
        }

        public override ASTNode VisitInt([NotNull] CoolParser.IntContext context)
        {
            return base.VisitInt(context);
        }

        public override ASTNode VisitIsvoid([NotNull] CoolParser.IsvoidContext context)
        {
            return base.VisitIsvoid(context);
        }

        public override ASTNode VisitLetIn([NotNull] CoolParser.LetInContext context)
        {
            return base.VisitLetIn(context);
        }

        public override ASTNode VisitMethod([NotNull] CoolParser.MethodContext context)
        {
            return base.VisitMethod(context);
        }

        public override ASTNode VisitNegative([NotNull] CoolParser.NegativeContext context)
        {
            return base.VisitNegative(context);
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
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using CoolCompiler.AST;
using System.Linq;

namespace CoolCompiler.ANTLR
{
    public class ASTBuilder : CoolBaseVisitor<ASTNode>
    {
        

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

        public override ASTNode VisitAdd([NotNull] CoolParser.AddContext context)
        {
            return base.VisitAdd(context);
        }

        public override ASTNode VisitAssignment([NotNull] CoolParser.AssignmentContext context)
        {
            return base.VisitAssignment(context);
        }

        public override ASTNode VisitBlock([NotNull] CoolParser.BlockContext context)
        {
            return base.VisitBlock(context);
        }

        public override ASTNode VisitBoolNot([NotNull] CoolParser.BoolNotContext context)
        {
            return base.VisitBoolNot(context);
        }

        public override ASTNode VisitCase([NotNull] CoolParser.CaseContext context)
        {
            return base.VisitCase(context);
        }

        public override ASTNode VisitChildren(IRuleNode node)
        {
            return base.VisitChildren(node);
        }

        public override ASTNode VisitClassDefine([NotNull] CoolParser.ClassDefineContext context)
        {
            return base.VisitClassDefine(context);
        }

        public override ASTNode VisitClasses([NotNull] CoolParser.ClassesContext context)
        {
            return base.VisitClasses(context);
        }

        public override ASTNode VisitDivision([NotNull] CoolParser.DivisionContext context)
        {
            return base.VisitDivision(context);
        }

        public override ASTNode VisitEof([NotNull] CoolParser.EofContext context)
        {
            return base.VisitEof(context);
        }

        public override ASTNode VisitEqual([NotNull] CoolParser.EqualContext context)
        {
            return base.VisitEqual(context);
        }

        public override ASTNode VisitErrorNode(IErrorNode node)
        {
            return base.VisitErrorNode(node);
        }

        public override ASTNode VisitFalse([NotNull] CoolParser.FalseContext context)
        {
            return base.VisitFalse(context);
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

        public override ASTNode VisitLessEqual([NotNull] CoolParser.LessEqualContext context)
        {
            return base.VisitLessEqual(context);
        }

        public override ASTNode VisitLessThan([NotNull] CoolParser.LessThanContext context)
        {
            return base.VisitLessThan(context);
        }

        public override ASTNode VisitLetIn([NotNull] CoolParser.LetInContext context)
        {
            return base.VisitLetIn(context);
        }

        public override ASTNode VisitMethod([NotNull] CoolParser.MethodContext context)
        {
            return base.VisitMethod(context);
        }

        public override ASTNode VisitMethodCall([NotNull] CoolParser.MethodCallContext context)
        {
            return base.VisitMethodCall(context);
        }

        public override ASTNode VisitMinus([NotNull] CoolParser.MinusContext context)
        {
            return base.VisitMinus(context);
        }

        public override ASTNode VisitMultiply([NotNull] CoolParser.MultiplyContext context)
        {
            return base.VisitMultiply(context);
        }

        public override ASTNode VisitNegative([NotNull] CoolParser.NegativeContext context)
        {
            return base.VisitNegative(context);
        }

        public override ASTNode VisitNew([NotNull] CoolParser.NewContext context)
        {
            return base.VisitNew(context);
        }

        public override ASTNode VisitOwnMethodCall([NotNull] CoolParser.OwnMethodCallContext context)
        {
            return base.VisitOwnMethodCall(context);
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

        public override ASTNode VisitTrue([NotNull] CoolParser.TrueContext context)
        {
            return base.VisitTrue(context);
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
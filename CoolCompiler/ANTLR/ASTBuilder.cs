using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using CoolCompiler.AST;

namespace CoolCompiler.ANTLR
{
    public class ASTBuilder : COOLBaseVisitor<ASTNode>
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

        public override ASTNode VisitAdd([NotNull] COOLParser.AddContext context)
        {
            return base.VisitAdd(context);
        }

        public override ASTNode VisitAssignment([NotNull] COOLParser.AssignmentContext context)
        {
            return base.VisitAssignment(context);
        }

        public override ASTNode VisitBlock([NotNull] COOLParser.BlockContext context)
        {
            return base.VisitBlock(context);
        }

        public override ASTNode VisitBoolNot([NotNull] COOLParser.BoolNotContext context)
        {
            return base.VisitBoolNot(context);
        }

        public override ASTNode VisitCase([NotNull] COOLParser.CaseContext context)
        {
            return base.VisitCase(context);
        }

        public override ASTNode VisitChildren(IRuleNode node)
        {
            return base.VisitChildren(node);
        }

        public override ASTNode VisitClassDefine([NotNull] COOLParser.ClassDefineContext context)
        {
            return base.VisitClassDefine(context);
        }

        public override ASTNode VisitClasses([NotNull] COOLParser.ClassesContext context)
        {
            return base.VisitClasses(context);
        }

        public override ASTNode VisitDivision([NotNull] COOLParser.DivisionContext context)
        {
            return base.VisitDivision(context);
        }

        public override ASTNode VisitEof([NotNull] COOLParser.EofContext context)
        {
            return base.VisitEof(context);
        }

        public override ASTNode VisitEqual([NotNull] COOLParser.EqualContext context)
        {
            return base.VisitEqual(context);
        }

        public override ASTNode VisitErrorNode(IErrorNode node)
        {
            return base.VisitErrorNode(node);
        }

        public override ASTNode VisitFalse([NotNull] COOLParser.FalseContext context)
        {
            return base.VisitFalse(context);
        }

        public override ASTNode VisitFormal([NotNull] COOLParser.FormalContext context)
        {
            return base.VisitFormal(context);
        }

        public override ASTNode VisitId([NotNull] COOLParser.IdContext context)
        {
            return base.VisitId(context);
        }

        public override ASTNode VisitIf([NotNull] COOLParser.IfContext context)
        {
            return base.VisitIf(context);
        }

        public override ASTNode VisitInt([NotNull] COOLParser.IntContext context)
        {
            return base.VisitInt(context);
        }

        public override ASTNode VisitIsvoid([NotNull] COOLParser.IsvoidContext context)
        {
            return base.VisitIsvoid(context);
        }

        public override ASTNode VisitLessEqual([NotNull] COOLParser.LessEqualContext context)
        {
            return base.VisitLessEqual(context);
        }

        public override ASTNode VisitLessThan([NotNull] COOLParser.LessThanContext context)
        {
            return base.VisitLessThan(context);
        }

        public override ASTNode VisitLetIn([NotNull] COOLParser.LetInContext context)
        {
            return base.VisitLetIn(context);
        }

        public override ASTNode VisitMethod([NotNull] COOLParser.MethodContext context)
        {
            return base.VisitMethod(context);
        }

        public override ASTNode VisitMethodCall([NotNull] COOLParser.MethodCallContext context)
        {
            return base.VisitMethodCall(context);
        }

        public override ASTNode VisitMinus([NotNull] COOLParser.MinusContext context)
        {
            return base.VisitMinus(context);
        }

        public override ASTNode VisitMultiply([NotNull] COOLParser.MultiplyContext context)
        {
            return base.VisitMultiply(context);
        }

        public override ASTNode VisitNegative([NotNull] COOLParser.NegativeContext context)
        {
            return base.VisitNegative(context);
        }

        public override ASTNode VisitNew([NotNull] COOLParser.NewContext context)
        {
            return base.VisitNew(context);
        }

        public override ASTNode VisitOwnMethodCall([NotNull] COOLParser.OwnMethodCallContext context)
        {
            return base.VisitOwnMethodCall(context);
        }

        public override ASTNode VisitParentheses([NotNull] COOLParser.ParenthesesContext context)
        {
            return base.VisitParentheses(context);
        }

        public override ASTNode VisitProgram([NotNull] COOLParser.ProgramContext context)
        {
            return base.VisitProgram(context);
        }

        public override ASTNode VisitProperty([NotNull] COOLParser.PropertyContext context)
        {
            return base.VisitProperty(context);
        }

        public override ASTNode VisitString([NotNull] COOLParser.StringContext context)
        {
            return base.VisitString(context);
        }

        public override ASTNode VisitTerminal(ITerminalNode node)
        {
            return base.VisitTerminal(node);
        }

        public override ASTNode VisitTrue([NotNull] COOLParser.TrueContext context)
        {
            return base.VisitTrue(context);
        }

        public override ASTNode VisitWhile([NotNull] COOLParser.WhileContext context)
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
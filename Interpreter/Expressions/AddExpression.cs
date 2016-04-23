
namespace Interpreter.Expressions
{
    //nonterminal expression, contains left and right expressions below it
    public class AddExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;

        public AddExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        int IExpression.Interpret()
        {
            return leftExpression.Interpret() + rightExpression.Interpret();
        }
    }
}

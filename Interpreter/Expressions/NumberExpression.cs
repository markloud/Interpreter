
namespace Interpreter.Expressions
{
    //terminal expression
    public class NumberExpression : IExpression
    {
        int number;
        public NumberExpression(int i)
        {
            number = i;
        }

        int IExpression.Interpret()
        {
            return number;
        }
    }
}

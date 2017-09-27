namespace Scorpio.Business.Models
{
    public class Expression
    {
        public string Expr { get; set; }

        // Field Operator Value

        public Expression(string expression)
        {
            Expr = expression;
        }
    }
}
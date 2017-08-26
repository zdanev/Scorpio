namespace Scorpio.Business.Models
{
    public class PasswordField : FormField
    {
        public PasswordField(string caption, string id) : base(caption, id)
        {   
        }
    }

    public static partial class FluentApi
    {
        public static PasswordField PasswordField(string caption, string id) => new PasswordField(caption, id);
    }
}
namespace Scorpio.Business.Models
{
    public class PasswordField : FormField
    {
        public PasswordField(string id, string caption) : base(id, caption)
        {   
        }
    }

    public static partial class FluentApi
    {
        public static PasswordField PasswordField(string id, string caption) => new PasswordField(id, caption);
    }
}
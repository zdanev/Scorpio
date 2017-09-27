namespace Scorpio.Business.Models
{
    public class SubmitButton : FormButton
    {
        public SubmitButton(string id, string caption) : base(id, caption)
        {   
        }
    }

    public static partial class FluentApi
    {
        public static SubmitButton SubmitButton(string id, string caption) => new SubmitButton(id, caption);
    }
}
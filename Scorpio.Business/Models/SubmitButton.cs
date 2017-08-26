namespace Scorpio.Business.Models
{
    public class SubmitButton : FormButton
    {
        public SubmitButton(string caption, string id) : base(caption, id)
        {   
        }
    }

    public static partial class FluentApi
    {
        public static SubmitButton SubmitButton(string caption, string id) => new SubmitButton(caption, id);
    }
}
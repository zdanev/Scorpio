namespace Scorpio.Business.Models
{
    public class FormButton : FormElement
    {
        public FormButton(string id, string caption) : base(id, caption)
        {   
        }
    }

    public static partial class FluentApi
    {
        public static FormButton FormButton(string id, string caption) => new FormButton(id, caption);
    }     
}
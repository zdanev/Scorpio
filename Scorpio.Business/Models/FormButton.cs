namespace Scorpio.Business.Models
{
    public class FormButton : FormField
    {
        public FormButton(string caption, string id) : base(caption, id)
        {   
        }
    }

    public static partial class FluentApi
    {
        public static FormButton FormButton(string caption, string id) => new FormButton(caption, id);
    }     
}
namespace Scorpio.Business.Models
{
    public class CheckBox : FormElement
    {
        public CheckBox(string id, string caption) : base(id, caption)
        {   
        }
    }

    public static partial class FluentApi
    {
        public static CheckBox CheckBox(string id, string caption) => new CheckBox(id, caption);
    }
}
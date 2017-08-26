namespace Scorpio.Business.Models
{
    public class CheckBox : FormField
    {
        public CheckBox(string caption, string id) : base(caption, id)
        {   
        }
    }

    public static partial class FluentApi
    {
        public static CheckBox CheckBox(string caption, string id) => new CheckBox(caption, id);
    }
}
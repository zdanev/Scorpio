namespace Scorpio.Business.Models
{
    public class TextField : FormField
    {
        public TextField(string caption, string id) : base(caption, id)
        {   
        }
    }

    public static partial class FluentApi
    {
        public static TextField TextField(string caption, string id) => new TextField(caption, id);
    }
}
namespace Scorpio.Business.Models
{
    public class TextField : FormField
    {
        public TextField(string id, string caption) : base(id, caption)
        {   
        }
    }

    public static partial class FluentApi
    {
        public static TextField TextField(string id, string caption) => new TextField(id, caption);
    }
}
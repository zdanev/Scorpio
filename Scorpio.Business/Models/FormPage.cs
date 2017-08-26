namespace Scorpio.Business.Models
{
    public class FormPage
    {
        public string Title { get; set; }

        public FormField[] Fields { get; set; }

        public FormPage(string title, params FormField[] fields)
        {
            Title = title;
            Fields = fields;            
        }
    }

    public static partial class FluentApi
    {
        public static FormPage FormPage(string title, params FormField[] fields) => new FormPage(title, fields);
    }
}
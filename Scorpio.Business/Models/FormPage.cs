namespace Scorpio.Business.Models
{
    public class FormPage
    {
        public string Title { get; set; }

        public FormElement[] Elements { get; set; }

        public FormPage(string title, params FormElement[] elements)
        {
            Title = title;
            Elements = elements;            
        }
    }

    public static partial class FluentApi
    {
        public static FormPage FormPage(string title, params FormElement[] fields) => new FormPage(title, fields);
    }
}
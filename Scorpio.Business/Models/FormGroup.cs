namespace Scorpio.Business.Models
{
    public class FormGroup : FormElement
    {
        public FormElement[] Elements { get; set; } // children?

        public FormGroup(string id, string caption, params FormElement[] elements) : base(id, caption)
        {
            Elements = elements;
        }
    }

    public static partial class FluentApi
    {
        public static FormGroup FormGroup(string id, string caption, params FormElement[] elements) => new FormGroup(id, caption, elements);
    }
}
namespace Scorpio.Business.Models
{
    public abstract class FormField
    {
        public string Caption { get; set; }

        public string Id { get; set; }

        public bool IsRequired { get; set; }

        public FormField(string caption, string id)
        {
            Caption = caption;
            Id = id;
        }
    }

    public static partial class FluentApi
    {
        public static T Required<T>(this T formField) where T : FormField
        {
            formField.IsRequired = true;
            return formField;
        }
    }
}
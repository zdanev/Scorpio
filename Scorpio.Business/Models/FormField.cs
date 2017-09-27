namespace Scorpio.Business.Models
{
    public class FormField : FormElement
    {
        // FieldType: alpha, numeric, special
        public bool IsRequired { get; set; }
        public Expression RequiredWhen { get; set; }
        // MinLength
        // MaxLength
        // RegEx
        // Mask
        public string Value { get; set;}

        public FormField(string id, string caption /* string value */) : base(id, caption)
        {
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
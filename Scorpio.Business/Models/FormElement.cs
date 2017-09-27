namespace Scorpio.Business.Models
{
    public abstract class FormElement
    {
        public string Id { get; set; }
        public string Caption { get; set; }
        public string Size { get; set; } // enum
        public bool IsVisible { get; set; } // IsHidden
        public bool IsEnabled { get; set; } // IsDisabled
        public Expression VisibleWhen { get; set; }
        public Expression HiddleWhen { get; set; }
        public Expression EnabledWhen { get; set; }
        public Expression DisabledWhen { get; set; }

        public FormElement(string id, string caption)
        {
            Id = id;
            Caption = caption;
        }
    }

}
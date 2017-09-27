namespace Scorpio.Business.Models
{
    public class CancelButton : FormButton
    {
        public CancelButton(string id, string caption) : base(id, caption)
        {   
        }
    }

    public static partial class FluentApi
    {
        public static CancelButton CancelButton(string id, string caption) => new CancelButton(id, caption);
    }  
}
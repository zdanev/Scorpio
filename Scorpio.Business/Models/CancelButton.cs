namespace Scorpio.Business.Models
{
    public class CancelButton : FormButton
    {
        public CancelButton(string caption, string id) : base(caption, id)
        {   
        }
    }

    public static partial class FluentApi
    {
        public static CancelButton CancelButton(string caption, string id) => new CancelButton(caption, id);
    }  
}
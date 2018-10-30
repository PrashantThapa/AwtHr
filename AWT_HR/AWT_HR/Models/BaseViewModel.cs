namespace AppHealth.Models
{
    public abstract class BaseViewModel
    {
        public int Id { get; set; }
        public string ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }
    }
}

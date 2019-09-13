namespace dummy_api.DataClasses
{
    public class LoginResource
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
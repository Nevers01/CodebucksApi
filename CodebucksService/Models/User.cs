using CodebucksService.Models.Helper;

namespace CodebucksService.Models
{
    public class User : CoreEntity
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string avatar { get; set; }
        public string bio { get; set; }

        // public int role { get; set; }
        // public int status { get; set; }
        public string remeber_token { get; set; }

        public string reset_token { get; set; }
        public DateTime reset_expires { get; set; }
        public DateTime last_login { get; set; }
    }
}
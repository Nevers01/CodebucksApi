using CodebucksService.Models.Helper;

namespace CodebucksService.Models
{
    public class Blacklist : CoreEntity
    {
        public string Email { get; set; }
        public string Reason { get; set; }
    }
}
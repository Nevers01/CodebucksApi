using CodebucksService.Models.Helper;

namespace CodebucksService.Models
{
    public class Contact : CoreEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string İp_address { get; set; }
        //public int Status { get; set; }
    }
}
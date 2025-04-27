using CodebucksService.Models.Helper;

namespace CodebucksService.Models
{
    public class Message : CoreEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string Messages { get; set; }
        public string İp_Address { get; set; }
        public string User_Agent { get; set; }
        public short İs_Blocked { get; set; }
        public string Block_Reason { get; set; }

        // public string email { get; set; }
        public DateTime Deleted_at { get; set; }

        public DateTime Deleted_by { get; set; }
    }
}
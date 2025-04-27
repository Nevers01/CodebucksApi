using System.Reflection.PortableExecutable;
using CodebucksService.Models.Helper;

namespace CodebucksService.Models
{
    public class Audit_log : CoreEntity
    {
        public int User_id { get; set; }
        public string Action { get; set; }
        public string Table_name { get; set; }
        public int Record_id { get; set; }
        public string Old_data { get; set; }
        public string New_data { get; set; }
        public string İp_address { get; set; }
    }
}
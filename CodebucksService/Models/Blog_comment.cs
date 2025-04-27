using System.Reflection.Metadata.Ecma335;
using CodebucksService.Models.Helper;

namespace CodebucksService.Models
{
    public class Blog_comment : CoreEntity
    {
        public int Post_id { get; set; }
        public int User_id { get; set; }
        public int Parent_id { get; set; }
        public string Content { get; set; }
        //public int Status { get; set; }
    }
}
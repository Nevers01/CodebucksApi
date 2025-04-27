using CodebucksService.Models.Helper;

namespace CodebucksService.Models
{
    public class Blog_categorie : CoreEntity
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public int Parent_id { get; set; }
        public string İcon { get; set; }
        public int Order_number { get; set; }
        //public int Status { get; set; }
    }
}
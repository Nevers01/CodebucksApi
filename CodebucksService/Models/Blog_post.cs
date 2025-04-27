using CodebucksService.Models.Helper;

namespace CodebucksService.Models
{
    public class Blog_post : CoreEntity
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public int Category_id { get; set; }
        public int Author_id { get; set; }
        public string Thumbnail { get; set; }
        public string Tags { get; set; }
        public string Meta_title { get; set; }
        public string Meta_description { get; set; }
        public int Views { get; set; }
        //public int Status { get; set; }
    }
}
using CodebucksService.Models.Helper;

namespace CodebucksService.Models
{
    public class Doc : CoreEntity
    {
        public int Category_id { get; set; }
        public int Author_id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public int Views { get; set; }

        //public int Status { get; set; }
        public int Order_Number { get; set; }
    }
}
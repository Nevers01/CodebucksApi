using CodebucksService.Models.Helper;

namespace CodebucksService.Models
{
    public class Demo : CoreEntity
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public int Author_id { get; set; }
        public string Thumbnail { get; set; }
        public string Demo_url { get; set; }
        public string Github_url { get; set; }
        public string Technologies { get; set; }
        public string Features { get; set; }
        public int Views { get; set; }
        //public int Status { get; set; }
    }
}
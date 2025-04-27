using CodebucksService.Models.Helper;

namespace CodebucksService.Models
{
    public class Edu_Lesson : CoreEntity
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }

        //public int Level { get; set; }
        public int Category_id { get; set; }

        public int Author_id { get; set; }
        public string Thumbnail { get; set; }
        public string Video_id { get; set; }
        public int Video_Duration { get; set; }
        public int Order_Number { get; set; }
        public int Views { get; set; }

        //public int Status { get; set; }
        public DateTime Deleted_at { get; set; }

        public int Deleted_by { get; set; }
    }
}
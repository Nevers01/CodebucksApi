using CodebucksService.Models.Helper;

namespace CodebucksService.Models
{
    public class Edu_Section : CoreEntity
    {
        public int Lesson_id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Video_id { get; set; }
        public int Video_Duration { get; set; }
        public int Order_Number { get; set; }
    }
}
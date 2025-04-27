using CodebucksService.Models.Helper;

namespace CodebucksService.Models
{
    public class Edu_Progres : CoreEntity
    {
        public int Lesson_id { get; set; }
        public int Section_id { get; set; }
        public int User_id { get; set; }
    }
}
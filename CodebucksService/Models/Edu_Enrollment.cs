using CodebucksService.Models.Helper;

namespace CodebucksService.Models
{
    public class Edu_Enrollment : CoreEntity
    {
        public int Lesson_id { get; set; }
        public int User_id { get; set; }
    }
}
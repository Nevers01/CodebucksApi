using CodebucksService.Models.Helper;

namespace CodebucksService.Models
{
    public class Setting : CoreEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
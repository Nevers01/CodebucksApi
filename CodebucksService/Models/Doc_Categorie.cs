using CodebucksService.Models.Helper;

namespace CodebucksService.Models
{
    public class Doc_Categorie : CoreEntity
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }

        //public int MyProperty3 { get; set; }
        public int order_Number { get; set; }
    }
}
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPortfolyoUdemy.DAL.Entities
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string Title { get; set; }

        public int Value { get; set; }
    }
}

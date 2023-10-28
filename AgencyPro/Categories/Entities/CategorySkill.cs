using System;
using AgencyPro.Skills.Entities;

namespace AgencyPro.Categories.Entities
{
    public class CategorySkill
    {
        public Guid SkillId { get; set; }
        public Skill Skill { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.Skills.Models;

namespace AgencyPro.Skills.Interfaces
{
    public interface ISkillService
    {
        Task<List<T>> GetAllSkills<T>() where T : SkillOutput;
        Task<List<T>> GetSkillsForCategory<T>(int categoryId) where T : SkillOutput;
    }
}
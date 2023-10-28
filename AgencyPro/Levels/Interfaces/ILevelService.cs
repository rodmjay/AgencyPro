using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.Levels.Models;

namespace AgencyPro.Levels.Interfaces
{
    public interface ILevelService
    {
        Task<List<LevelOutput>> GetLevels(int positionId);
    }
}

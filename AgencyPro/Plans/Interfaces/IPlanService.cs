using System.Threading.Tasks;
using AgencyPro.Common.Models;
using AgencyPro.Plans.Entities;

namespace AgencyPro.Plans.Interfaces
{
    public interface IPlanService
    {
        Task<Result> PushPlan(StripePlan plan, bool commit = true);


        Task<int> ExportPlans();

    }
}
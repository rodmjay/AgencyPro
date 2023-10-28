using AgencyPro.Categories.Interfaces;
using Newtonsoft.Json;

namespace AgencyPro.Categories.Models
{
    public class CategoryOutput : CategoryInput, ICategory
    {
        public virtual int CategoryId { get; set; }

        [JsonIgnore] public virtual bool Searchable { get; set; }
        public decimal DefaultRecruiterStream { get; set; }
        public decimal DefaultMarketerStream { get; set; }
        public decimal DefaultProjectManagerStream { get; set; }
        public decimal DefaultAccountManagerStream { get; set; }
        public decimal DefaultContractorStream { get; set; }
        public decimal DefaultAgencyStream { get; set; }
    }
}
using System.Data.Entity;

namespace InsuranceQuoteApp.Models
{
    public class InsuranceEntities : DbContext
    {
        public InsuranceEntities() : base("name=InsuranceConnection") { }

        public DbSet<Insuree> Insurees { get; set; }
    }
}

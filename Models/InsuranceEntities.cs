using System.Collections.Generic;
using System.Data.Entity;

namespace ASPNetMVC_InsuranceQuote.Models
{
    public class InsuranceEntities : DbContext
    {
        public InsuranceEntities() : base("name=InsuranceConnection")
        {
        }

        public DbSet<Insuree> Insurees { get; set; }
    }
}
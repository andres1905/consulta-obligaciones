using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligaciones.Data
{
    public class TaxContext : DbContext
    {
        public DbSet<TaxPayer> TaxPayers { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<TaxRecord> TaxRecords { get; set; }
    }
}

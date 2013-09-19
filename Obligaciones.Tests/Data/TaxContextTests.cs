using NUnit.Framework;
using Obligaciones.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligaciones.Tests.Data
{
    [TestFixture]
    public class TaxContextTests
    {
        [Test]
        public void TaxContext_IsDbContext()
        {
            var taxContext = new TaxContext();

            Assert.IsInstanceOf<DbContext>(taxContext);
        }

        [Test]
        public void TaxContext_HasSetsForTaxPayerTaxRecordAndProperties()
        {
            var taxContext = new TaxContext();

            Assert.IsTrue(taxContext.TaxPayers is DbSet<TaxPayer>);
            Assert.IsTrue(taxContext.Properties is DbSet<Property>);
            Assert.IsTrue(taxContext.TaxRecords is DbSet<TaxRecord>);
        }
    }
}

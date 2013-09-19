using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Obligaciones.Data;

namespace Obligaciones.Tests.Data
{
    [TestFixture]
    public class TaxRecordTests
    {
        [Test]
        public void TaxRecord_HasDescriptionAndValue()
        {
            var taxRecord = new TaxRecord()
            {
                Description = "Security Tax",
                Value = 19.00
            };

            Assert.IsInstanceOf<TaxRecord>(taxRecord);
            Assert.AreEqual(taxRecord.Description, "Security Tax");
            Assert.AreEqual(taxRecord.Value, 19.00);
        }
    }
}

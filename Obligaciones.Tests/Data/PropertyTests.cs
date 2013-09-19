using NUnit.Framework;
using Obligaciones.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligaciones.Tests.Data
{
    [TestFixture]
    public class PropertyTests
    {
        [Test]
        public void Property_HasAddressPropertyIDAndKey()
        {
            var property = new Property()
            {
                Address = "Calle A 125 y Calle B",
                PropertyID = "0938483",
                Key = "04993 09 372"
            };

            Assert.IsInstanceOf<Property>(property);
            Assert.AreEqual(property.Address, "Calle A 125 y Calle B");
            Assert.AreEqual(property.PropertyID, "0938483");
            Assert.AreEqual(property.Key, "04993 09 372");
        }

        [Test]
        public void Property_HasARelationshipToATaxPayer()
        {
            var property = new Property()
            {
                Address = "Calle A 125 y Calle B",
                PropertyID = "0938483",
                Key = "04993 09 372"
            };
            var taxPayer = new TaxPayer()
            {
                Name = "Marcela",
                LastName = "Riofrio",
                IDNumber = "1700000001"
            };
            property.TaxPayer = taxPayer;

            Assert.IsInstanceOf<TaxPayer>(property.TaxPayer);
            Assert.AreEqual(property.TaxPayer, taxPayer);
        }

        [Test]
        public void Property_CanHaveNoTaxRecords()
        {
            var property = new Property()
            {
                Address = "Calle A 125 y Calle B",
                PropertyID = "0938483",
                Key = "04993 09 372"
            };

            Assert.IsNotNull(property.TaxRecords);
        }

        [Test]
        public void Property_HasYearlyTaxRecords()
        {
            var property = new Property()
            {
                Address = "Calle A 125 y Calle B",
                PropertyID = "0938483",
                Key = "04993 09 372"
            };
            var _2010Records = new List<TaxRecord>();
            property.TaxRecords.Add(2010, _2010Records);
            var _2011Records = new List<TaxRecord>();
            property.TaxRecords.Add(2011, _2011Records);

            Assert.IsTrue(property.TaxRecords.ContainsValue(_2010Records));
            Assert.IsTrue(property.TaxRecords.ContainsValue(_2011Records));
        }
    }
}


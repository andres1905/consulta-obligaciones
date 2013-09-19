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
    public class TaxPayerTests
    {
        [Test]
        public void TaxPayer_HasNameLastNameIDNumber()
        {
            var taxPayer = new TaxPayer()
            {
                Name = "Marcela",
                LastName = "Riofrio",
                IDNumber = "1700000001"
            };

            Assert.IsInstanceOf<TaxPayer>(taxPayer);
            Assert.AreEqual(taxPayer.Name, "Marcela");
            Assert.AreEqual(taxPayer.LastName, "Riofrio");
            Assert.AreEqual(taxPayer.IDNumber, "1700000001");
        }

        [Test]
        public void TaxPayer_HasProperties()
        {
            var taxPayer = new TaxPayer()
            {
                Name = "Marcela",
                LastName = "Riofrio",
                IDNumber = "1700000001"
            };
            var property1 = new Property();
            var property2 = new Property();
            var properties = new List<Property> {property1, property2};

            taxPayer.Properties = properties;

            CollectionAssert.Contains(taxPayer.Properties, property1);
            CollectionAssert.Contains(taxPayer.Properties, property2);
        }
    }
}

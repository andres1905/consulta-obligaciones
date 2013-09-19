using NUnit.Framework;
using Obligaciones.Data;
using Obligaciones.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Obligaciones.Tests.Controllers
{
    [TestFixture]
    public class TaxPayerControllerTests
    {
        [Test]
        public void GetTaxPayer_Get_TestReturnsTaxPayerGivenHisIDNumber()
        {
            var idNumber = "1700000001";
            var controller = new TaxPayerController();

            var taxPayer = controller.GetTaxPayer(idNumber);

            Assert.IsInstanceOf<TaxPayer>(taxPayer);
            Assert.AreEqual(taxPayer.IDNumber, idNumber);
        }

        [Test]
        public void GetTaxPayer_Get_TestThrowsBadRequestExceptionWhenNoIDNumber()
        {
            var controller = new TaxPayerController();

            try
            {
                var taxPayer = controller.GetTaxPayer(null);

                Assert.Fail("Exception should have been thrown");
            }
            catch (HttpResponseException ex)
            {
                Assert.AreEqual(ex.Response.StatusCode, HttpStatusCode.BadRequest);
            }
        }

        [Test]
        public void GetTaxPayer_Get_TestThrowsNotFoundExceptionOnWrongIDNumber()
        {
            var controller = new TaxPayerController();

            try
            {
                var taxPayer = controller.GetTaxPayer("0000000000");

                Assert.Fail("Exception should have been thrown");
            }
            catch (HttpResponseException ex)
            {
                Assert.AreEqual(ex.Response.StatusCode, HttpStatusCode.NotFound);
            }
        }
    }
}

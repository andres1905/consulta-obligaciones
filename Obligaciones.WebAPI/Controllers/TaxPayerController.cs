using Obligaciones.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Obligaciones.WebAPI.Controllers
{
    public class TaxPayerController : ApiController
    {
        public TaxPayer GetTaxPayer(string IDNumber)
        {
            if (IDNumber == null)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            return new TaxPayer { IDNumber = IDNumber };
        }
    }
}

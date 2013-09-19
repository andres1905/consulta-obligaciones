using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligaciones.Data
{
    public class Property
    {
        public string Address { get; set; }
        public string PropertyID { get; set; }
        public string Key { get; set; }
        public TaxPayer TaxPayer { get; set; }

        public Dictionary<int, List<TaxRecord>> TaxRecords  { get; private set; }

        public Property()
        {
            TaxRecords = new Dictionary<int, List<TaxRecord>>();
        }
    }
}

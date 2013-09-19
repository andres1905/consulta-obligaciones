using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligaciones.Data
{
    public class TaxPayer
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string IDNumber { get; set; }

        public List<Property> Properties { get; set; }
    }
}

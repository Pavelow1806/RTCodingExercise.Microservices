using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Domain.Responses
{
    public class ConfigurationResponse
    {
        public decimal MarkupMultiplier { get; set; }
        public int ItemsPerPage { get; set; }
    }
}

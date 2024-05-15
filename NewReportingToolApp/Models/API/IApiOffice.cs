using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewReportingToolApp.Models.API
{
    public interface IApiOffice
    {
        string dept { get; set; }
        string position { get; set; }
        string from_date { get; set; }

        string to_date { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewReportingToolApp.Models
{
    public interface IModel
    {
        List<IMemberInfo> ReturnData();
    }
}

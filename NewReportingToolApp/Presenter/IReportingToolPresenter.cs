using NewReportingToolApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewReportingToolApp.Presenter
{
    public interface IReportingToolPresenter
    {
        

        void FillDataTable(List<IMemberInfo> list);
        void ReturnDataView(DataView dv);
        void UpdateView(object sender, EventArgs e);
    }
}

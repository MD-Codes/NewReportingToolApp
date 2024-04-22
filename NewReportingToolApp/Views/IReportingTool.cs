using System;
using System.Data;
using System.Windows.Forms;

namespace NewReportingToolApp
{
    public interface IReportingTool
    {
        DataView dv { get; set; }
        DataTable dt { get; set; }
        string TextBoxString { get; set; }
        event EventHandler SearchAttempted;
        void SetDataView(DataView data);
        void addColums();
    }
}
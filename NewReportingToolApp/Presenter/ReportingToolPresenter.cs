using NewReportingToolApp;
using NewReportingToolApp.Models;
using System.Collections.Generic;
using System.Data;

public class ReportingToolPresenter : Observer
{
    private readonly IReportingTool _View;
    private readonly IModel _Model;

    public ReportingToolPresenter(IReportingTool view, IModel model)
    {
        _View = view;
        _Model = model;
        fillDataTable(_Model.ReturnData());
        //_View.SearchAttempted += UpdateView;
        ReturnDataView(_View.dv);
        _View.RegisterObserver(this);

    }
    public void fillDataTable(List<IMemberInfo> list)
    {

        foreach (var item in list)
        {
            _View.dt.Rows.Add(item.Name, item.Donors, item.PartyName, item.TotalAmount);
        }

    }
    public void ReturnDataView(DataView dv)
    {
        _View.SetDataView(dv);
    }
    //public void UpdateView(object sender, EventArgs e)
    //{

    //    _View.dv.RowFilter = string.Format("Name Like '%{0}%'", _View.TextBoxString);
    //    ReturnDataView(_View.dv);
    //}
    public void OnSearchTextChanged(string searchText)
    {
        _View.dv.RowFilter = string.Format("Name Like '%{0}%'", searchText);
        _View.SetDataView(_View.dv);
    }

}

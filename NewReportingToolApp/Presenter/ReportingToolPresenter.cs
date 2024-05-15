using NewReportingToolApp;
using NewReportingToolApp.Models;
using NewReportingToolApp.Models.API;
using System.Collections.Generic;
using System.Data;
using static NewReportingToolApp.Models.API.ApiMembers;

public class ReportingToolPresenter : Observer
{
    
    private readonly IReportingTool _View;
    private readonly IApiModel _Model;

    public ReportingToolPresenter(IReportingTool view, IApiModel model)
    {
        _View = view;
        _Model = model;
        fillDataTable(_Model.ReturnData());
        //_View.SearchAttempted += UpdateView;
        ReturnDataView(_View.dv);
        _View.RegisterObserver(this);

    }
    public void fillDataTable(List<Class1> list)
    {

        foreach (var item in list)
        {
            _View.dt.Rows.Add(item.name, item.person_id, item.party, item.office);
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

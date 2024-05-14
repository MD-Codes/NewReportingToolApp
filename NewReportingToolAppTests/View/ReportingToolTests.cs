using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewReportingToolApp.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace NewReportingToolApp.Tests
{
    [TestClass()]
    public class ReportingToolTests
    {
        public Form1 view = new Form1();
        [TestMethod()]
        public void ReportingToolTestCheckShouldCreateColumnWithProperNames()
        {            
            view.addColums();

            Assert.AreSame("Name", view.dt.Columns[0].ColumnName, message: "First position should be Name");
            Assert.AreSame("Donors", view.dt.Columns[1].ColumnName, message: "Second position should be Donors");
            Assert.AreSame("Party", view.dt.Columns[2].ColumnName, message: "third position should be Party");
            Assert.AreSame("Total Amount", view.dt.Columns[3].ColumnName, message: "Fourth position should be Total Amount");
            
        }       
        [TestMethod()]
        public void ReportingToolTestCheckSetDataToDataView()
        {
            DataView dv = view.dv;
            view.SetDataView(dv);

            Assert.IsNotNull(view.dv, message: "SetDataView Should be not null");
        }
        [TestMethod()]
        public void ReportingToolTestCheckTextBoxStringCanBeSet()
        {
            var view = new DummForm1();

            view.TextBoxString = "text";
            
            Assert.AreEqual("text", view.TextBoxString, message: "Should be the same");
        }

    }
    class DummForm1 : IReportingTool
    {
        public DataView dv { get; set; }
        public DataTable dt { get ; set; }
        public string TextBoxString { get; set; }

        public event EventHandler SearchAttempted;

        public void addColums()
        {
            dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Donors");
            dt.Columns.Add("Party");
            dt.Columns.Add("Total Amount");
            dv = new DataView(dt);
        }

        public void RegisterObserver(Observer observer)
        {
        }

        public void SetDataView(DataView data) 
        {
        }
    }


}
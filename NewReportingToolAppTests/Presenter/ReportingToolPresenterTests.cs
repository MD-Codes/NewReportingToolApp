using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewReportingToolApp;
using NewReportingToolApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ReportingToolTests
{
    public class DummyModel : IModel
    {
       

        List<IMemberInfo> list = new List<IMemberInfo>();
        public  List<IMemberInfo> ReturnData()
        {
            list.Add(new IMemberInfo
            {
                Name = "MemberName",
                Donors = "MemberDonors",
                PartyName = "MemberPartyName",
                TotalAmount = 1.00
            });
            list.Add(new IMemberInfo
            {
                Name = "Adam",
                Donors = "Adam",
                PartyName = "Adam",
                TotalAmount = 100.00
            });
            return list;
        }

    }
    [TestClass()]
    public class ReportingToolPresenterTests
    {
        [TestMethod()]
        public void UpdateViewTestShouldReturnUpdatedData()
        {
            //Arrange
            var _View = new Form1();
            var _Model = new DummyModel();

            //Act
            var presenter = new ReportingToolPresenter(_View, _Model);
            _View.TextBoxString = "MemberName";
            presenter.ReturnDataView(_View.dv);
            //Assert
            Assert.AreEqual(1, _View.dv.Count);
            Assert.AreEqual("Name Like '%MemberName%'", _View.dv.RowFilter);
        }
        [TestMethod()]
        public void ReportingToolTestCheckAddingMembersToDataView()
        {
            Form1 view = new Form1();
            var primaryCapacity = view.dv.Count;
            view.dt.Rows.Add("Name", "Donors", "Party", 20.11);

            Assert.AreNotEqual(primaryCapacity, view.dv.Count, message: "Should return different value of capacity after adding data");
        }
        [TestMethod()]
        public void ParseDispleyListTest_Should_Add_Member_To_The_List()
        {
            //Arange
            Form1 view = new Form1();
            DummyModel model = new DummyModel();
            ReportingToolPresenter presenter = new ReportingToolPresenter(view, model);
            List<IMemberInfo> list1 = new List<IMemberInfo>();
            list1.Add(new IMemberInfo
            {
                Name = "MemberNameTest",
                Donors = "MemberDonorsTest",
                PartyName = "MemberPartyNameTest",
                TotalAmount =2.00
            });

            //Act
            presenter.fillDataTable(list1);

            //Assert
            Assert.AreEqual(3, view.dv.Count);
        }
    }

}
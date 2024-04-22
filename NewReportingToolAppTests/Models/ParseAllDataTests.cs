using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewReportingToolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewReportingToolApp.Models.Tests
{
    [TestClass()]
    public class ParseAllDataTests
    {
        [TestMethod()]
        public void ParseDispleyListTest_Should_Add_Member_To_The_List()
        {
            //Arange
            Model list = new Model();
            int newCapacity;
            //Act
            var result = list.ReturnData();
            newCapacity = result.Count + 1;
            result.Add(new IMemberInfo
            {
                UserId = result.Count,
                Name = "Name",
                PartyName = "PartyName",
                Donors = "donors",
                TotalAmount = 0.00
            });
            //Assert
            Assert.AreEqual(result.Count, newCapacity);
        }
    }
}
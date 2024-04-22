using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewReportingToolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportingToolTests.ModelTests
{
    [TestClass()]
    public class ModelTests
    {       
        [TestMethod()]
        public void ModelTest_Should_Return_List_Of_DataType_DisplayList()
        {
            //Arange
            Model list = new Model();

            //Act
            var result = list.ReturnData();

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<IMemberInfo>), message: " should return Datatype list<ImemberInfo>");
        }
        [TestMethod()]
        public void ModelTest_Should_Not_Be_Null()
        {
            //Arange
            Model list = new Model();

            //Act
            var result = list.ReturnData();
            //Assert
            Assert.IsNotNull(result, message: "Should not be null");
        }
        
    }
}
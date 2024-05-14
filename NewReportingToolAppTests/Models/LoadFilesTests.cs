using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewReportingToolApp.Models;
using NewReportingToolAppTests.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.PropertyGridInternal;

namespace NewReportingToolApp.Models.Tests
{
    [TestClass()]
    public class LoadFilesTests
    {
        [TestMethod()]
        public void LoadFileTest_should_return_DataType_publicwhip()
        {
            //Arrange

            LoadFiles<publicwhip> publicwhipFile = new LoadFiles<publicwhip>();
            string address = File.ReadAllText("C:\\Users\\matda\\Desktop\\Projects_c#\\NewReportingToolApp\\NewReportingToolAppTests\\Models\\XMLFile2.xml");
             
            //Act

            var regmem = publicwhipFile.LoadFile(address);
            //Assert
            Assert.IsInstanceOfType(regmem, typeof(publicwhip));
        }
        [TestMethod()]
        public void LoadFileTest_should_NotBeNull_For_publicwhip()
        {
            //Arrange
            LoadFiles<publicwhip> publicwhipFile = new LoadFiles<publicwhip>();
            string address = File.ReadAllText("C:\\Users\\matda\\Desktop\\Projects_c#\\NewReportingToolApp\\NewReportingToolAppTests\\Models\\XMLFile2.xml");
            //Act

            publicwhip regmem = publicwhipFile.LoadFile(address);
            //Assert
            Assert.IsNotNull(regmem);
        }
        [TestMethod()]
        public void LoadFileTest_should_return_DataType_ArrayOfIPartyAffiliation()
        {
            //Arrange
            LoadFiles<ArrayOfIPartyAffiliation> AOIPA = new LoadFiles<ArrayOfIPartyAffiliation>();
            string address = File.ReadAllText("C:\\Users\\matda\\Desktop\\Projects_c#\\NewReportingToolApp\\NewReportingToolAppTests\\Models\\XMLFile1.xml");
            //Act

            ArrayOfIPartyAffiliation regmem = AOIPA.LoadFile(address);

            //Assert
            Assert.IsInstanceOfType(regmem, typeof(ArrayOfIPartyAffiliation));
        }
        [TestMethod()]
        public void LoadFileTest_should_NotBeNull_For_PartyAffiliation()
        {
            //Arrange
            LoadFiles<ArrayOfIPartyAffiliation> publicwhipFile = new LoadFiles<ArrayOfIPartyAffiliation>();
            string address = File.ReadAllText(@"C:\Users\matda\Desktop\Projects_c#\NewReportingToolApp\NewReportingToolAppTests\Models\XMLFile1.xml");
            //Act

            ArrayOfIPartyAffiliation regmem = publicwhipFile.LoadFile(address);
            //Assert
            Assert.IsNotNull(regmem);
        }
    }
}
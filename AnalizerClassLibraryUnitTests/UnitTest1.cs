using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AnalaizerClassLibrary;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AnalizerClassUnitTests
{
    [TestClass]
    public class AnalizerClassTests
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"C:\Users\ірка\Desktop\Calculator\AnalizerClassLibraryUnitTests\XMLFile2.xml", "Test", DataAccessMethod.Sequential)]

        [TestMethod]
        public void SeparateTest()
        {
            
            //ffff
                //Arange
            string input = Convert.ToString(TestContext.DataRow["input"]);
            IEnumerable<string> expected = Convert.ToString(TestContext.DataRow["expected"]).Split(',').ToArray();
            //Act
            IEnumerable<string> actual = AnalaizerClass.Separate(input);

            //Assert
            CollectionAssert.AreEqual(expected.ToList(), actual.ToList());
        }
    }
}

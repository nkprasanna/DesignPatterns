using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiscConsoleApp;

namespace Grade.Test
{
    [TestClass]
    public class GradeBookTestcs
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook buk = new GradeBook();
            buk.AddGrade(10);
            buk.AddGrade(90);
            GradeStatics res = buk.ComputeStatitcs();
            Assert.AreEqual(99, res.HighestGrade);
        }
        [TestMethod]
        public void MyTestMethod()
        {

        }
    }
}

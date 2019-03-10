using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FirstUnitTestProject
{
    [TestClass]
    public class UnitTest1 : dmuka2.CS.UnitTest.BaseUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(dmuka2.CS.UnitTest.IsUnitTest.Check);
        }
    }
}

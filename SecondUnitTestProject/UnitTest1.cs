using NUnit.Framework;

namespace Tests
{
    public class Tests : dmuka2.CS.UnitTest.BaseUnitTest
    {
        [Test]
        public void Test1()
        {
            Assert.IsTrue(dmuka2.CS.UnitTest.IsUnitTest.Check);
        }
    }
}
using System;
using Xunit;

namespace ThirdUnitTestProject
{
    public class UnitTest1 : dmuka2.CS.UnitTest.BaseUnitTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(dmuka2.CS.UnitTest.IsUnitTest.Check);
        }
    }
}

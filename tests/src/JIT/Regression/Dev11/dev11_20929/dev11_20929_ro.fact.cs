using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_dev11_20929_dev11_20929_ro_dev11_20929_ro_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_dev11_20929_dev11_20929_ro_dev11_20929_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\dev11_20929\\dev11_20929_ro\\dev11_20929_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

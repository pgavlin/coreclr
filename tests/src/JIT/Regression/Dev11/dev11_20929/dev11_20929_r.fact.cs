using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_dev11_20929_dev11_20929_r_dev11_20929_r_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_dev11_20929_dev11_20929_r_dev11_20929_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\dev11_20929\\dev11_20929_r\\dev11_20929_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_dev11_20929_dev11_20929_d_dev11_20929_d_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_dev11_20929_dev11_20929_d_dev11_20929_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\dev11_20929\\dev11_20929_d\\dev11_20929_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

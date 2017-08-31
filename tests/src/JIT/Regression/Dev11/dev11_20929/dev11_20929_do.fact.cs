using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_dev11_20929_dev11_20929_do_dev11_20929_do_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_dev11_20929_dev11_20929_do_dev11_20929_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\dev11_20929\\dev11_20929_do\\dev11_20929_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

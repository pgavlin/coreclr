using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_External_dev11_111914_BadMax1_BadMax1_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_External_dev11_111914_BadMax1_BadMax1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\External\\dev11_111914\\BadMax1\\BadMax1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

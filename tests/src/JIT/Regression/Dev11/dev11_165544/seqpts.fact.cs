using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_dev11_165544_seqpts_seqpts_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_dev11_165544_seqpts_seqpts_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\dev11_165544\\seqpts\\seqpts.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

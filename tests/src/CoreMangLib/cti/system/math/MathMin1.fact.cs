using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_math_MathMin1_MathMin1_
    {
        [OuterLoop]
        [Fact]
        public void _system_math_MathMin1_MathMin1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\math\\MathMin1\\MathMin1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

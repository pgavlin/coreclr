using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_math_MathAbs2_MathAbs2_
    {
        [OuterLoop]
        [Fact]
        public void _system_math_MathAbs2_MathAbs2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\math\\MathAbs2\\MathAbs2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

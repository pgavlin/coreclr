using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_math_MathMin8_MathMin8_
    {
        [OuterLoop]
        [Fact]
        public void _system_math_MathMin8_MathMin8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\math\\MathMin8\\MathMin8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

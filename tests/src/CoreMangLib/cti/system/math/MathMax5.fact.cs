using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_math_MathMax5_MathMax5_
    {
        [OuterLoop]
        [Fact]
        public void _system_math_MathMax5_MathMax5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\math\\MathMax5\\MathMax5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

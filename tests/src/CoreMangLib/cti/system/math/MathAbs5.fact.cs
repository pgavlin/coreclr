using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_math_MathAbs5_MathAbs5_
    {
        [OuterLoop]
        [Fact]
        public void _system_math_MathAbs5_MathAbs5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\math\\MathAbs5\\MathAbs5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Overflow_FloatOvfToInt2_r_FloatOvfToInt2_r_
    {
        [OuterLoop]
        [Fact]
        public void _Overflow_FloatOvfToInt2_r_FloatOvfToInt2_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Overflow\\FloatOvfToInt2_r\\FloatOvfToInt2_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

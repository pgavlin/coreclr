using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Overflow_FloatOvfToInt2_ro_FloatOvfToInt2_ro_
    {
        [OuterLoop]
        [Fact]
        public void _Overflow_FloatOvfToInt2_ro_FloatOvfToInt2_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Overflow\\FloatOvfToInt2_ro\\FloatOvfToInt2_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Overflow_FloatOvfToInt2_do_FloatOvfToInt2_do_
    {
        [OuterLoop]
        [Fact]
        public void _Overflow_FloatOvfToInt2_do_FloatOvfToInt2_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Overflow\\FloatOvfToInt2_do\\FloatOvfToInt2_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

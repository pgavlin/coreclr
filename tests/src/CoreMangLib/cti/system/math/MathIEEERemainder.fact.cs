using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_math_MathIEEERemainder_MathIEEERemainder_
    {
        [OuterLoop]
        [Fact]
        public void _system_math_MathIEEERemainder_MathIEEERemainder_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\math\\MathIEEERemainder\\MathIEEERemainder.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

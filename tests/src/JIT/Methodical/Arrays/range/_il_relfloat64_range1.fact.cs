using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_range__il_relfloat64_range1__il_relfloat64_range1_
    {
        [Fact]
        public void _Arrays_range__il_relfloat64_range1__il_relfloat64_range1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\range\\_il_relfloat64_range1\\_il_relfloat64_range1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

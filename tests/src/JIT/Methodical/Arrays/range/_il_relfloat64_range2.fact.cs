using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_range__il_relfloat64_range2__il_relfloat64_range2_
    {
        [Fact]
        public void _Arrays_range__il_relfloat64_range2__il_relfloat64_range2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\range\\_il_relfloat64_range2\\_il_relfloat64_range2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

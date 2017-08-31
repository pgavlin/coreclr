using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_range__il_relint32_0_5b__il_relint32_0_5b_
    {
        [Fact]
        public void _Arrays_range__il_relint32_0_5b__il_relint32_0_5b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\range\\_il_relint32_0_5b\\_il_relint32_0_5b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

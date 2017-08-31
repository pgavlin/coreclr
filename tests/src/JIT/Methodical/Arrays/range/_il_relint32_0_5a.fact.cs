using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_range__il_relint32_0_5a__il_relint32_0_5a_
    {
        [Fact]
        public void _Arrays_range__il_relint32_0_5a__il_relint32_0_5a_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\range\\_il_relint32_0_5a\\_il_relint32_0_5a.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

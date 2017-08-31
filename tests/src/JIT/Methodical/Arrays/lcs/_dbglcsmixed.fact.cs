using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_lcs__dbglcsmixed__dbglcsmixed_
    {
        [Fact]
        public void _Arrays_lcs__dbglcsmixed__dbglcsmixed_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\lcs\\_dbglcsmixed\\_dbglcsmixed.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

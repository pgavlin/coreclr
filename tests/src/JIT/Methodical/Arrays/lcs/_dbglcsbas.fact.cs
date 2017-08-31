using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_lcs__dbglcsbas__dbglcsbas_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_lcs__dbglcsbas__dbglcsbas_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\lcs\\_dbglcsbas\\_dbglcsbas.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

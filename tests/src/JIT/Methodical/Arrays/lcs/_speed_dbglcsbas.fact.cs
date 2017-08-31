using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_lcs__speed_dbglcsbas__speed_dbglcsbas_
    {
        [Fact]
        public void _Arrays_lcs__speed_dbglcsbas__speed_dbglcsbas_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\lcs\\_speed_dbglcsbas\\_speed_dbglcsbas.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_lcs__speed_rellcsbas__speed_rellcsbas_
    {
        [Fact]
        public void _Arrays_lcs__speed_rellcsbas__speed_rellcsbas_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\lcs\\_speed_rellcsbas\\_speed_rellcsbas.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

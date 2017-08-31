using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_lcs__speed_rellcs__speed_rellcs_
    {
        [Fact]
        public void _Arrays_lcs__speed_rellcs__speed_rellcs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\lcs\\_speed_rellcs\\_speed_rellcs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

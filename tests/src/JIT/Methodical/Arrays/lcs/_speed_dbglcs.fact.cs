using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_lcs__speed_dbglcs__speed_dbglcs_
    {
        [Fact]
        public void _Arrays_lcs__speed_dbglcs__speed_dbglcs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\lcs\\_speed_dbglcs\\_speed_dbglcs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

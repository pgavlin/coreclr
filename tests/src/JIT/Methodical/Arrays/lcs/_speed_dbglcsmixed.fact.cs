using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_lcs__speed_dbglcsmixed__speed_dbglcsmixed_
    {
        [Fact]
        public void _Arrays_lcs__speed_dbglcsmixed__speed_dbglcsmixed_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\lcs\\_speed_dbglcsmixed\\_speed_dbglcsmixed.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

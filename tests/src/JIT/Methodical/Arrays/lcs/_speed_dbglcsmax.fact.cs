using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_lcs__speed_dbglcsmax__speed_dbglcsmax_
    {
        [Fact]
        public void _Arrays_lcs__speed_dbglcsmax__speed_dbglcsmax_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\lcs\\_speed_dbglcsmax\\_speed_dbglcsmax.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

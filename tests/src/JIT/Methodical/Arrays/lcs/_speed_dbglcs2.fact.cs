using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_lcs__speed_dbglcs2__speed_dbglcs2_
    {
        [Fact]
        public void _Arrays_lcs__speed_dbglcs2__speed_dbglcs2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\lcs\\_speed_dbglcs2\\_speed_dbglcs2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

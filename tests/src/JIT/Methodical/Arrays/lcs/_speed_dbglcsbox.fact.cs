using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_lcs__speed_dbglcsbox__speed_dbglcsbox_
    {
        [Fact]
        public void _Arrays_lcs__speed_dbglcsbox__speed_dbglcsbox_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\lcs\\_speed_dbglcsbox\\_speed_dbglcsbox.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

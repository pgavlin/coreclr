using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_lcs__speed_dbglcsvalbox__speed_dbglcsvalbox_
    {
        [Fact]
        public void _Arrays_lcs__speed_dbglcsvalbox__speed_dbglcsvalbox_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\lcs\\_speed_dbglcsvalbox\\_speed_dbglcsvalbox.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

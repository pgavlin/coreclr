using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_lcs__speed_rellcsvalbox__speed_rellcsvalbox_
    {
        [Fact]
        public void _Arrays_lcs__speed_rellcsvalbox__speed_rellcsvalbox_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\lcs\\_speed_rellcsvalbox\\_speed_rellcsvalbox.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

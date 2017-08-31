using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _rmv_il_RMV_2_15_12b_RMV_2_15_12b_
    {
        [Fact]
        public void _rmv_il_RMV_2_15_12b_RMV_2_15_12b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\rmv\\il\\RMV-2-15-12b\\RMV-2-15-12b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

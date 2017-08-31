using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _rmv_il_RMV_2_13_25_five_RMV_2_13_25_five_
    {
        [OuterLoop]
        [Fact]
        public void _rmv_il_RMV_2_13_25_five_RMV_2_13_25_five_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\rmv\\il\\RMV-2-13-25-five\\RMV-2-13-25-five.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

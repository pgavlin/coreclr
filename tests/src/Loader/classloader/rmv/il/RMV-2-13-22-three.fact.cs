using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _rmv_il_RMV_2_13_22_three_RMV_2_13_22_three_
    {
        [OuterLoop]
        [Fact]
        public void _rmv_il_RMV_2_13_22_three_RMV_2_13_22_three_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\rmv\\il\\RMV-2-13-22-three\\RMV-2-13-22-three.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

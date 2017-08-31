using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _rmv_il_RMV_2_5_5_two_RMV_2_5_5_two_
    {
        [OuterLoop]
        [Fact]
        public void _rmv_il_RMV_2_5_5_two_RMV_2_5_5_two_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\rmv\\il\\RMV-2-5-5-two\\RMV-2-5-5-two.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

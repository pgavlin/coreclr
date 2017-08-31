using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _rmv_il_RMV_2_13_41a_two_RMV_2_13_41a_two_
    {
        [OuterLoop]
        [Fact]
        public void _rmv_il_RMV_2_13_41a_two_RMV_2_13_41a_two_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\rmv\\il\\RMV-2-13-41a-two\\RMV-2-13-41a-two.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

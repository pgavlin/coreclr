using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _rmv_il_RMV_2_8_20_one_RMV_2_8_20_one_
    {
        [OuterLoop]
        [Fact]
        public void _rmv_il_RMV_2_8_20_one_RMV_2_8_20_one_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\rmv\\il\\RMV-2-8-20-one\\RMV-2-8-20-one.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

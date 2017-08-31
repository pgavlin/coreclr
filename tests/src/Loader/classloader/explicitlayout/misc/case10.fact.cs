using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _explicitlayout_misc_case10_case10_
    {
        [OuterLoop]
        [Fact]
        public void _explicitlayout_misc_case10_case10_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\explicitlayout\\misc\\case10\\case10.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

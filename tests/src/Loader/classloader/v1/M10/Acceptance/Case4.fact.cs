using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _v1_M10_Acceptance_Case4_Case4_
    {
        [OuterLoop]
        [Fact]
        public void _v1_M10_Acceptance_Case4_Case4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\v1\\M10\\Acceptance\\Case4\\Case4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

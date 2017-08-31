using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _v1_M10_Acceptance_Case1_Case1_
    {
        [OuterLoop]
        [Fact]
        public void _v1_M10_Acceptance_Case1_Case1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\v1\\M10\\Acceptance\\Case1\\Case1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _v1_M10_Acceptance_Case3_Case3_
    {
        [OuterLoop]
        [Fact]
        public void _v1_M10_Acceptance_Case3_Case3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\v1\\M10\\Acceptance\\Case3\\Case3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

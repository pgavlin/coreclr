using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _v1_M10_Acceptance_Case2_Case2_
    {
        [OuterLoop]
        [Fact]
        public void _v1_M10_Acceptance_Case2_Case2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\v1\\M10\\Acceptance\\Case2\\Case2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

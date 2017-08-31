using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_583649_vsw583649_vsw583649_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_583649_vsw583649_vsw583649_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\583649\\vsw583649\\vsw583649.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

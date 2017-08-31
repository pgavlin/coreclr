using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_regressions_334376_b334376_b334376_
    {
        [OuterLoop]
        [Fact]
        public void _generics_regressions_334376_b334376_b334376_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\334376\\b334376\\b334376.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_regressions_448208_b448208_b448208_
    {
        [OuterLoop]
        [Fact]
        public void _generics_regressions_448208_b448208_b448208_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\448208\\b448208\\b448208.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

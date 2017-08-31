using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_regressions_137310_test137310_test137310_
    {
        [OuterLoop]
        [Fact]
        public void _generics_regressions_137310_test137310_test137310_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\137310\\test137310\\test137310.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

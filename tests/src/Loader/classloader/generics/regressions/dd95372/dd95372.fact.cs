using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_regressions_dd95372_dd95372_dd95372_
    {
        [OuterLoop]
        [Fact]
        public void _generics_regressions_dd95372_dd95372_dd95372_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\dd95372\\dd95372\\dd95372.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

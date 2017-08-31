using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_regressions_433497_vsw433497_vsw433497_
    {
        [OuterLoop]
        [Fact]
        public void _generics_regressions_433497_vsw433497_vsw433497_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\433497\\vsw433497\\vsw433497.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

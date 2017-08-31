using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _nesting_coreclr_VSW491577_VSW491577_
    {
        [OuterLoop]
        [Fact]
        public void _nesting_coreclr_VSW491577_VSW491577_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\nesting\\coreclr\\VSW491577\\VSW491577.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _nesting_coreclr_exec16_exec16_
    {
        [OuterLoop]
        [Fact]
        public void _nesting_coreclr_exec16_exec16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\nesting\\coreclr\\exec16\\exec16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _nesting_coreclr_nesting4_nesting4_
    {
        [OuterLoop]
        [Fact]
        public void _nesting_coreclr_nesting4_nesting4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\nesting\\coreclr\\nesting4\\nesting4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

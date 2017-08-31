using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _nesting_coreclr_nesting18_nesting18_
    {
        [OuterLoop]
        [Fact]
        public void _nesting_coreclr_nesting18_nesting18_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\nesting\\coreclr\\nesting18\\nesting18.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

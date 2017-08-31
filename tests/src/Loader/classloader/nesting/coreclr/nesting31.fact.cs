using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _nesting_coreclr_nesting31_nesting31_
    {
        [OuterLoop]
        [Fact]
        public void _nesting_coreclr_nesting31_nesting31_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\nesting\\coreclr\\nesting31\\nesting31.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

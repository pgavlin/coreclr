using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _nesting_Tests_nesting7_nesting7_
    {
        [OuterLoop]
        [Fact]
        public void _nesting_Tests_nesting7_nesting7_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\nesting\\Tests\\nesting7\\nesting7.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

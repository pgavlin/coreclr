using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _nesting_Tests_nesting63_nesting63_
    {
        [OuterLoop]
        [Fact]
        public void _nesting_Tests_nesting63_nesting63_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\nesting\\Tests\\nesting63\\nesting63.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

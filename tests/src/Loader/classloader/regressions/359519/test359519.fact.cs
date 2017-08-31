using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_359519_test359519_test359519_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_359519_test359519_test359519_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\359519\\test359519\\test359519.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

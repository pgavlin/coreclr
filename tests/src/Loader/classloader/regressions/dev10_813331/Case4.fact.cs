using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_dev10_813331_Case4_Case4_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_dev10_813331_Case4_Case4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\dev10_813331\\Case4\\Case4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_dev10_813331_Case2_Case2_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_dev10_813331_Case2_Case2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\dev10_813331\\Case2\\Case2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

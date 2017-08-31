using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_dev10_813331_Case3_Case3_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_dev10_813331_Case3_Case3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\dev10_813331\\Case3\\Case3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

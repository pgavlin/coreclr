using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _regressions_v4_0_640474_test640474_test640474_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_v4_0_640474_test640474_test640474_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\v4.0\\640474\\test640474\\test640474.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

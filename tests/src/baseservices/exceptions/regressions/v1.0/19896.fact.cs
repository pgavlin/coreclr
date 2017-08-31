using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _regressions_v1_0_19896_19896_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_v1_0_19896_19896_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\v1.0\\19896\\19896.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

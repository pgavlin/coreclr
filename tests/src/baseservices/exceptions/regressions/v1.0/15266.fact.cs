using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _regressions_v1_0_15266_15266_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_v1_0_15266_15266_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\v1.0\\15266\\15266.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

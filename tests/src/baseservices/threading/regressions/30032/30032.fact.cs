using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _regressions_30032_30032_30032_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_30032_30032_30032_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\30032\\30032\\30032.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

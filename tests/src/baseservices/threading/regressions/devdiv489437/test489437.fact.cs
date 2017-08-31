using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _regressions_devdiv489437_test489437_test489437_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_devdiv489437_test489437_test489437_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\devdiv489437\\test489437\\test489437.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

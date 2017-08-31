using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _StackTracePreserve_StackTracePreserveTests_StackTracePreserveTests_
    {
        [OuterLoop]
        [Fact]
        public void _StackTracePreserve_StackTracePreserveTests_StackTracePreserveTests_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\StackTracePreserve\\StackTracePreserveTests\\StackTracePreserveTests.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

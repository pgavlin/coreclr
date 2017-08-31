using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _events_EventWaitHandle_unit_AutoConstructFalse_AutoConstructFalse_
    {
        [OuterLoop]
        [Fact]
        public void _events_EventWaitHandle_unit_AutoConstructFalse_AutoConstructFalse_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\events\\EventWaitHandle\\unit\\AutoConstructFalse\\AutoConstructFalse.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

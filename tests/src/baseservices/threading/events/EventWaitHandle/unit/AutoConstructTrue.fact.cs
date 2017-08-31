using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _events_EventWaitHandle_unit_AutoConstructTrue_AutoConstructTrue_
    {
        [OuterLoop]
        [Fact]
        public void _events_EventWaitHandle_unit_AutoConstructTrue_AutoConstructTrue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\events\\EventWaitHandle\\unit\\AutoConstructTrue\\AutoConstructTrue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _events_EventWaitHandle_unit_AutoConstructFalse_AutoConstructFalse_
    {
        [OuterLoop]
        [Fact]
        public void _events_EventWaitHandle_unit_AutoConstructFalse_AutoConstructFalse_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\events\\EventWaitHandle\\unit\\AutoConstructFalse\\AutoConstructFalse.cmd");
        }
    }
}

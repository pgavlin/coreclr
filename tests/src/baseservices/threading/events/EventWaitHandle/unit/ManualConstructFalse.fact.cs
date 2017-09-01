using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _events_EventWaitHandle_unit_ManualConstructFalse_ManualConstructFalse_
    {
        [OuterLoop]
        [Fact]
        public void _events_EventWaitHandle_unit_ManualConstructFalse_ManualConstructFalse_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\events\\EventWaitHandle\\unit\\ManualConstructFalse\\ManualConstructFalse.cmd");
        }
    }
}

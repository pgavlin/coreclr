using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _events_EventWaitHandle_unit_ManualConstructTrue_ManualConstructTrue_
    {
        [OuterLoop]
        [Fact]
        public void _events_EventWaitHandle_unit_ManualConstructTrue_ManualConstructTrue_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\events\\EventWaitHandle\\unit\\ManualConstructTrue\\ManualConstructTrue.cmd");
        }
    }
}

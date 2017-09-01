using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _events_EventWaitHandle_unit_AutoConstructTrue_AutoConstructTrue_
    {
        [OuterLoop]
        [Fact]
        public void _events_EventWaitHandle_unit_AutoConstructTrue_AutoConstructTrue_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\events\\EventWaitHandle\\unit\\AutoConstructTrue\\AutoConstructTrue.cmd");
        }
    }
}

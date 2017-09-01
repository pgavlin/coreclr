using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _events_EventWaitHandle_ManualReset_ManualResetCtor2_ManualResetCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _events_EventWaitHandle_ManualReset_ManualResetCtor2_ManualResetCtor2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\events\\EventWaitHandle\\ManualReset\\ManualResetCtor2\\ManualResetCtor2.cmd");
        }
    }
}

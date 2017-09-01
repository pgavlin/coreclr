using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _events_EventWaitHandle_ManualReset_ManualResetCtor1_ManualResetCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _events_EventWaitHandle_ManualReset_ManualResetCtor1_ManualResetCtor1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\events\\EventWaitHandle\\ManualReset\\ManualResetCtor1\\ManualResetCtor1.cmd");
        }
    }
}

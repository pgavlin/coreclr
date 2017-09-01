using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _events_EventWaitHandle_AutoReset_AutoResetCtor2_AutoResetCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _events_EventWaitHandle_AutoReset_AutoResetCtor2_AutoResetCtor2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\events\\EventWaitHandle\\AutoReset\\AutoResetCtor2\\AutoResetCtor2.cmd");
        }
    }
}

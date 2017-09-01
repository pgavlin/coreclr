using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _events_ManualResetEvent_ConstructFalse_ConstructFalse_
    {
        [OuterLoop]
        [Fact]
        public void _events_ManualResetEvent_ConstructFalse_ConstructFalse_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\events\\ManualResetEvent\\ConstructFalse\\ConstructFalse.cmd");
        }
    }
}

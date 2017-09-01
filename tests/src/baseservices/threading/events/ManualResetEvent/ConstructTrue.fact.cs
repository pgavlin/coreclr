using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _events_ManualResetEvent_ConstructTrue_ConstructTrue_
    {
        [OuterLoop]
        [Fact]
        public void _events_ManualResetEvent_ConstructTrue_ConstructTrue_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\events\\ManualResetEvent\\ConstructTrue\\ConstructTrue.cmd");
        }
    }
}

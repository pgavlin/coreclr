using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _events_AutoResetEvent_ConstructTrue_ConstructTrue_
    {
        [OuterLoop]
        [Fact]
        public void _events_AutoResetEvent_ConstructTrue_ConstructTrue_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\events\\AutoResetEvent\\ConstructTrue\\ConstructTrue.cmd");
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _monitor_enter_monitorenter_monitorenter_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_enter_monitorenter_monitorenter_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\enter\\monitorenter\\monitorenter.cmd");
        }
    }
}

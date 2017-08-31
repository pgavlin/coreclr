using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _monitor_enter_monitorenter_monitorenter_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_enter_monitorenter_monitorenter_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\enter\\monitorenter\\monitorenter.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

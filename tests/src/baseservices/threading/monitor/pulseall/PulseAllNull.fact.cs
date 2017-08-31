using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _monitor_pulseall_PulseAllNull_PulseAllNull_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_pulseall_PulseAllNull_PulseAllNull_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\pulseall\\PulseAllNull\\PulseAllNull.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

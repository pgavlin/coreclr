using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _monitor_pulseall_PulseAllNull_PulseAllNull_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_pulseall_PulseAllNull_PulseAllNull_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\pulseall\\PulseAllNull\\PulseAllNull.cmd");
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _monitor_pulse_PulseNull_PulseNull_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_pulse_PulseNull_PulseNull_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\pulse\\PulseNull\\PulseNull.cmd");
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _monitor_pulse_PulseNull_PulseNull_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_pulse_PulseNull_PulseNull_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\pulse\\PulseNull\\PulseNull.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

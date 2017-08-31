using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanTicksPerHour_TimeSpanTicksPerHour_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanTicksPerHour_TimeSpanTicksPerHour_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanTicksPerHour\\TimeSpanTicksPerHour.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

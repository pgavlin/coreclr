using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanTicksPerDay_TimeSpanTicksPerDay_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanTicksPerDay_TimeSpanTicksPerDay_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanTicksPerDay\\TimeSpanTicksPerDay.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

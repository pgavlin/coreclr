using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanTotalDays_TimeSpanTotalDays_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanTotalDays_TimeSpanTotalDays_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanTotalDays\\TimeSpanTotalDays.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

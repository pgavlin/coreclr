using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanTotalHours_TimeSpanTotalHours_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanTotalHours_TimeSpanTotalHours_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanTotalHours\\TimeSpanTotalHours.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanTotalMinutes_TimeSpanTotalMinutes_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanTotalMinutes_TimeSpanTotalMinutes_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanTotalMinutes\\TimeSpanTotalMinutes.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanTicksPerMinute_TimeSpanTicksPerMinute_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanTicksPerMinute_TimeSpanTicksPerMinute_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanTicksPerMinute\\TimeSpanTicksPerMinute.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

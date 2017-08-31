using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanTicksPerSecond_TimeSpanTicksPerSecond_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanTicksPerSecond_TimeSpanTicksPerSecond_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanTicksPerSecond\\TimeSpanTicksPerSecond.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

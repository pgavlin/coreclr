using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanDuration_TimeSpanDuration_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanDuration_TimeSpanDuration_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanDuration\\TimeSpanDuration.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

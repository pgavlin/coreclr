using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanTicks_TimeSpanTicks_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanTicks_TimeSpanTicks_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanTicks\\TimeSpanTicks.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

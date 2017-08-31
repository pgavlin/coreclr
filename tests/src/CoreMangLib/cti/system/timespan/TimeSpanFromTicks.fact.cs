using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanFromTicks_TimeSpanFromTicks_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanFromTicks_TimeSpanFromTicks_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanFromTicks\\TimeSpanFromTicks.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

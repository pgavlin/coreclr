using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanTotalSeconds_TimeSpanTotalSeconds_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanTotalSeconds_TimeSpanTotalSeconds_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanTotalSeconds\\TimeSpanTotalSeconds.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

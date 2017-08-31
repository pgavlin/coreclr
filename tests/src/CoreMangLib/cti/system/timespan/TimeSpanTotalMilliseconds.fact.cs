using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanTotalMilliseconds_TimeSpanTotalMilliseconds_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanTotalMilliseconds_TimeSpanTotalMilliseconds_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanTotalMilliseconds\\TimeSpanTotalMilliseconds.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

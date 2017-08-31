using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanZero_TimeSpanZero_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanZero_TimeSpanZero_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanZero\\TimeSpanZero.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

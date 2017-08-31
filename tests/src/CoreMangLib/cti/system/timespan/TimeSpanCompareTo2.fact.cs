using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanCompareTo2_TimeSpanCompareTo2_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanCompareTo2_TimeSpanCompareTo2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanCompareTo2\\TimeSpanCompareTo2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

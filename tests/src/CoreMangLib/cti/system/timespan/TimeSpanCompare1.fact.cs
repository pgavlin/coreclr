using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanCompare1_TimeSpanCompare1_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanCompare1_TimeSpanCompare1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanCompare1\\TimeSpanCompare1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

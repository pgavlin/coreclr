using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanMaxValue_TimeSpanMaxValue_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanMaxValue_TimeSpanMaxValue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanMaxValue\\TimeSpanMaxValue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

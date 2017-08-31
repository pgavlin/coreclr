using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanMinValue_TimeSpanMinValue_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanMinValue_TimeSpanMinValue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanMinValue\\TimeSpanMinValue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

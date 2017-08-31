using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanEquals3_TimeSpanEquals3_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanEquals3_TimeSpanEquals3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanEquals3\\TimeSpanEquals3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

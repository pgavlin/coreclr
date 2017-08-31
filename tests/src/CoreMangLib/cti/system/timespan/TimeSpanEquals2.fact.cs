using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanEquals2_TimeSpanEquals2_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanEquals2_TimeSpanEquals2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanEquals2\\TimeSpanEquals2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

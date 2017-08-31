using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanEquals1_TimeSpanEquals1_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanEquals1_TimeSpanEquals1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanEquals1\\TimeSpanEquals1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

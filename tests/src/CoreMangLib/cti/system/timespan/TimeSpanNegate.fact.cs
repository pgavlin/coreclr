using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanNegate_TimeSpanNegate_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanNegate_TimeSpanNegate_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanNegate\\TimeSpanNegate.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

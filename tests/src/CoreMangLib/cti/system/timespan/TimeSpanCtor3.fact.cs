using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanCtor3_TimeSpanCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanCtor3_TimeSpanCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanCtor3\\TimeSpanCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

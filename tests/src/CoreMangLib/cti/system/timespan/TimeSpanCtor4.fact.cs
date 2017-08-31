using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanCtor4_TimeSpanCtor4_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanCtor4_TimeSpanCtor4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanCtor4\\TimeSpanCtor4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

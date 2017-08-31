using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanGetHashCode_TimeSpanGetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanGetHashCode_TimeSpanGetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanGetHashCode\\TimeSpanGetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

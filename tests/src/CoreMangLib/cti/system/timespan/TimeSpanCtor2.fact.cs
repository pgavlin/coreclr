using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanCtor2_TimeSpanCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanCtor2_TimeSpanCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanCtor2\\TimeSpanCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

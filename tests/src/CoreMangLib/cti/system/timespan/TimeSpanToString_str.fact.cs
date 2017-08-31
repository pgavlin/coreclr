using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timespan_TimeSpanToString_str_TimeSpanToString_str_
    {
        [OuterLoop]
        [Fact]
        public void _system_timespan_TimeSpanToString_str_TimeSpanToString_str_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timespan\\TimeSpanToString_str\\TimeSpanToString_str.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

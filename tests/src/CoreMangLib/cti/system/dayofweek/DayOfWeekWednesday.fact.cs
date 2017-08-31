using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_dayofweek_DayOfWeekWednesday_DayOfWeekWednesday_
    {
        [OuterLoop]
        [Fact]
        public void _system_dayofweek_DayOfWeekWednesday_DayOfWeekWednesday_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\dayofweek\\DayOfWeekWednesday\\DayOfWeekWednesday.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

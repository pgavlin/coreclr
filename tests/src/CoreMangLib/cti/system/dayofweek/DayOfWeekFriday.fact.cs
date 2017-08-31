using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_dayofweek_DayOfWeekFriday_DayOfWeekFriday_
    {
        [OuterLoop]
        [Fact]
        public void _system_dayofweek_DayOfWeekFriday_DayOfWeekFriday_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\dayofweek\\DayOfWeekFriday\\DayOfWeekFriday.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

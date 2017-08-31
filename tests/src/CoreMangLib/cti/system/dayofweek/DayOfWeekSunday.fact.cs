using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_dayofweek_DayOfWeekSunday_DayOfWeekSunday_
    {
        [OuterLoop]
        [Fact]
        public void _system_dayofweek_DayOfWeekSunday_DayOfWeekSunday_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\dayofweek\\DayOfWeekSunday\\DayOfWeekSunday.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

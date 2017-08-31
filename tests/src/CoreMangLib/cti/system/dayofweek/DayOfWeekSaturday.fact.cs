using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_dayofweek_DayOfWeekSaturday_DayOfWeekSaturday_
    {
        [OuterLoop]
        [Fact]
        public void _system_dayofweek_DayOfWeekSaturday_DayOfWeekSaturday_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\dayofweek\\DayOfWeekSaturday\\DayOfWeekSaturday.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

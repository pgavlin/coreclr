using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_dayofweek_DayOfWeekMonday_DayOfWeekMonday_
    {
        [OuterLoop]
        [Fact]
        public void _system_dayofweek_DayOfWeekMonday_DayOfWeekMonday_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\dayofweek\\DayOfWeekMonday\\DayOfWeekMonday.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

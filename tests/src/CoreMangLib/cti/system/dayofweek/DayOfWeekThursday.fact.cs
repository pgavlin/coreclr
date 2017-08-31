using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_dayofweek_DayOfWeekThursday_DayOfWeekThursday_
    {
        [OuterLoop]
        [Fact]
        public void _system_dayofweek_DayOfWeekThursday_DayOfWeekThursday_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\dayofweek\\DayOfWeekThursday\\DayOfWeekThursday.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

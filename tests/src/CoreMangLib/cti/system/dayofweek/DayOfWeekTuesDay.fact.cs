using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_dayofweek_DayOfWeekTuesDay_DayOfWeekTuesDay_
    {
        [OuterLoop]
        [Fact]
        public void _system_dayofweek_DayOfWeekTuesDay_DayOfWeekTuesDay_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\dayofweek\\DayOfWeekTuesDay\\DayOfWeekTuesDay.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

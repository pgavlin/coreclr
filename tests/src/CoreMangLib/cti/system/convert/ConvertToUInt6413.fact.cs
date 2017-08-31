using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt6413_ConvertToUInt6413_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt6413_ConvertToUInt6413_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt6413\\ConvertToUInt6413.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

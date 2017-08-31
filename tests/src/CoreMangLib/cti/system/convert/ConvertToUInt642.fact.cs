using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt642_ConvertToUInt642_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt642_ConvertToUInt642_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt642\\ConvertToUInt642.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToSingle15_ConvertToSingle15_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToSingle15_ConvertToSingle15_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToSingle15\\ConvertToSingle15.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

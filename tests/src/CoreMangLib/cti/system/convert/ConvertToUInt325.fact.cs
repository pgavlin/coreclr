using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt325_ConvertToUInt325_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt325_ConvertToUInt325_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt325\\ConvertToUInt325.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt3216_ConvertToUInt3216_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt3216_ConvertToUInt3216_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt3216\\ConvertToUInt3216.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

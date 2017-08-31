using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt3210_ConvertToUInt3210_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt3210_ConvertToUInt3210_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt3210\\ConvertToUInt3210.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

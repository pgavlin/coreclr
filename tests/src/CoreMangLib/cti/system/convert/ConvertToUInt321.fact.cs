using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt321_ConvertToUInt321_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt321_ConvertToUInt321_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt321\\ConvertToUInt321.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

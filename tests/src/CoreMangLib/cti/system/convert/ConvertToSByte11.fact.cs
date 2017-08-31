using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToSByte11_ConvertToSByte11_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToSByte11_ConvertToSByte11_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToSByte11\\ConvertToSByte11.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

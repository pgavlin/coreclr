using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToSByte_ConvertToSByte_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToSByte_ConvertToSByte_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToSByte\\ConvertToSByte.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

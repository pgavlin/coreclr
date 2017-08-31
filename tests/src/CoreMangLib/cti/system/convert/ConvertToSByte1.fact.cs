using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToSByte1_ConvertToSByte1_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToSByte1_ConvertToSByte1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToSByte1\\ConvertToSByte1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

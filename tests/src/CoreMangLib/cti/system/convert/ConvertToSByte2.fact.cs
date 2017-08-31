using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToSByte2_ConvertToSByte2_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToSByte2_ConvertToSByte2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToSByte2\\ConvertToSByte2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

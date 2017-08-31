using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToSByte5_ConvertToSByte5_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToSByte5_ConvertToSByte5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToSByte5\\ConvertToSByte5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

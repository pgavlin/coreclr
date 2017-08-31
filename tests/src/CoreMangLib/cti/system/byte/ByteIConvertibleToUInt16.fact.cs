using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_byte_ByteIConvertibleToUInt16_ByteIConvertibleToUInt16_
    {
        [OuterLoop]
        [Fact]
        public void _system_byte_ByteIConvertibleToUInt16_ByteIConvertibleToUInt16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\byte\\ByteIConvertibleToUInt16\\ByteIConvertibleToUInt16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

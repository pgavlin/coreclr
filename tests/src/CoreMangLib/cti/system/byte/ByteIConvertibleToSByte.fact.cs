using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_byte_ByteIConvertibleToSByte_ByteIConvertibleToSByte_
    {
        [OuterLoop]
        [Fact]
        public void _system_byte_ByteIConvertibleToSByte_ByteIConvertibleToSByte_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\byte\\ByteIConvertibleToSByte\\ByteIConvertibleToSByte.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

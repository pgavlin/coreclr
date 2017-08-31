using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_byte_ByteIConvertibleToByte_ByteIConvertibleToByte_
    {
        [OuterLoop]
        [Fact]
        public void _system_byte_ByteIConvertibleToByte_ByteIConvertibleToByte_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\byte\\ByteIConvertibleToByte\\ByteIConvertibleToByte.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

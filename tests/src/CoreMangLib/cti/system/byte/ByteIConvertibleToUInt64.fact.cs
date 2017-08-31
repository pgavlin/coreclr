using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_byte_ByteIConvertibleToUInt64_ByteIConvertibleToUInt64_
    {
        [OuterLoop]
        [Fact]
        public void _system_byte_ByteIConvertibleToUInt64_ByteIConvertibleToUInt64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\byte\\ByteIConvertibleToUInt64\\ByteIConvertibleToUInt64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

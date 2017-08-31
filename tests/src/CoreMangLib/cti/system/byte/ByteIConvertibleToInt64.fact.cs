using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_byte_ByteIConvertibleToInt64_ByteIConvertibleToInt64_
    {
        [OuterLoop]
        [Fact]
        public void _system_byte_ByteIConvertibleToInt64_ByteIConvertibleToInt64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\byte\\ByteIConvertibleToInt64\\ByteIConvertibleToInt64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

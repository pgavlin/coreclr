using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint64_UInt64IConvertibleToChar_UInt64IConvertibleToChar_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint64_UInt64IConvertibleToChar_UInt64IConvertibleToChar_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint64\\UInt64IConvertibleToChar\\UInt64IConvertibleToChar.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

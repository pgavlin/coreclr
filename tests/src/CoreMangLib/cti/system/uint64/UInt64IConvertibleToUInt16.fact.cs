using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint64_UInt64IConvertibleToUInt16_UInt64IConvertibleToUInt16_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint64_UInt64IConvertibleToUInt16_UInt64IConvertibleToUInt16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint64\\UInt64IConvertibleToUInt16\\UInt64IConvertibleToUInt16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

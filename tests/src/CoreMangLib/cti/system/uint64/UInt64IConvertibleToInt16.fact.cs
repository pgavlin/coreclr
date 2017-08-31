using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint64_UInt64IConvertibleToInt16_UInt64IConvertibleToInt16_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint64_UInt64IConvertibleToInt16_UInt64IConvertibleToInt16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint64\\UInt64IConvertibleToInt16\\UInt64IConvertibleToInt16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

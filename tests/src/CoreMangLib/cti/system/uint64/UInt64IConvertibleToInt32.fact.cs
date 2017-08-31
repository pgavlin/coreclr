using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint64_UInt64IConvertibleToInt32_UInt64IConvertibleToInt32_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint64_UInt64IConvertibleToInt32_UInt64IConvertibleToInt32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint64\\UInt64IConvertibleToInt32\\UInt64IConvertibleToInt32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

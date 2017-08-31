using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint64_UInt64IConvertibleToSingle_UInt64IConvertibleToSingle_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint64_UInt64IConvertibleToSingle_UInt64IConvertibleToSingle_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint64\\UInt64IConvertibleToSingle\\UInt64IConvertibleToSingle.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

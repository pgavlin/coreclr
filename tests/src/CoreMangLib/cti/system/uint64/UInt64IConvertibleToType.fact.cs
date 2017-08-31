using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint64_UInt64IConvertibleToType_UInt64IConvertibleToType_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint64_UInt64IConvertibleToType_UInt64IConvertibleToType_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint64\\UInt64IConvertibleToType\\UInt64IConvertibleToType.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

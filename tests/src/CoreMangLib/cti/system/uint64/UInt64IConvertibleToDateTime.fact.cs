using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint64_UInt64IConvertibleToDateTime_UInt64IConvertibleToDateTime_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint64_UInt64IConvertibleToDateTime_UInt64IConvertibleToDateTime_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint64\\UInt64IConvertibleToDateTime\\UInt64IConvertibleToDateTime.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint32_UInt32IConvertibleToUInt64_UInt32IConvertibleToUInt64_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint32_UInt32IConvertibleToUInt64_UInt32IConvertibleToUInt64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint32\\UInt32IConvertibleToUInt64\\UInt32IConvertibleToUInt64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

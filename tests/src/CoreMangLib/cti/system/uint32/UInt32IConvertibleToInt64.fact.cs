using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint32_UInt32IConvertibleToInt64_UInt32IConvertibleToInt64_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint32_UInt32IConvertibleToInt64_UInt32IConvertibleToInt64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint32\\UInt32IConvertibleToInt64\\UInt32IConvertibleToInt64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

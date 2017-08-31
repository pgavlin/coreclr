using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint32_UInt32IConvertibleToInt16_UInt32IConvertibleToInt16_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint32_UInt32IConvertibleToInt16_UInt32IConvertibleToInt16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint32\\UInt32IConvertibleToInt16\\UInt32IConvertibleToInt16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint16_UInt16IConvertibleToInt32_UInt16IConvertibleToInt32_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint16_UInt16IConvertibleToInt32_UInt16IConvertibleToInt32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint16\\UInt16IConvertibleToInt32\\UInt16IConvertibleToInt32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

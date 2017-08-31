using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint16_UInt16IConvertibleToInt16_UInt16IConvertibleToInt16_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint16_UInt16IConvertibleToInt16_UInt16IConvertibleToInt16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint16\\UInt16IConvertibleToInt16\\UInt16IConvertibleToInt16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

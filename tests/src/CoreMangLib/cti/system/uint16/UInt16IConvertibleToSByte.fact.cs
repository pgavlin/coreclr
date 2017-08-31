using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint16_UInt16IConvertibleToSByte_UInt16IConvertibleToSByte_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint16_UInt16IConvertibleToSByte_UInt16IConvertibleToSByte_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint16\\UInt16IConvertibleToSByte\\UInt16IConvertibleToSByte.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint16_UInt16IConvertibleToDecimal_UInt16IConvertibleToDecimal_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint16_UInt16IConvertibleToDecimal_UInt16IConvertibleToDecimal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint16\\UInt16IConvertibleToDecimal\\UInt16IConvertibleToDecimal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

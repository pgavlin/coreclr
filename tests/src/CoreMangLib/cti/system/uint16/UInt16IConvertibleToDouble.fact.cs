using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint16_UInt16IConvertibleToDouble_UInt16IConvertibleToDouble_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint16_UInt16IConvertibleToDouble_UInt16IConvertibleToDouble_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint16\\UInt16IConvertibleToDouble\\UInt16IConvertibleToDouble.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint16_UInt16IConvertibleToDateTime_UInt16IConvertibleToDateTime_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint16_UInt16IConvertibleToDateTime_UInt16IConvertibleToDateTime_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint16\\UInt16IConvertibleToDateTime\\UInt16IConvertibleToDateTime.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

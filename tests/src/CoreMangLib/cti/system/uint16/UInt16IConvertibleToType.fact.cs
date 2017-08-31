using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint16_UInt16IConvertibleToType_UInt16IConvertibleToType_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint16_UInt16IConvertibleToType_UInt16IConvertibleToType_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint16\\UInt16IConvertibleToType\\UInt16IConvertibleToType.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

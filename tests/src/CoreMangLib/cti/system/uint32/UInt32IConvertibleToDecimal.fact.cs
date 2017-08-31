using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint32_UInt32IConvertibleToDecimal_UInt32IConvertibleToDecimal_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint32_UInt32IConvertibleToDecimal_UInt32IConvertibleToDecimal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint32\\UInt32IConvertibleToDecimal\\UInt32IConvertibleToDecimal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

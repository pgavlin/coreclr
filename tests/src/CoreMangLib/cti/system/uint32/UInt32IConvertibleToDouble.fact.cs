using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint32_UInt32IConvertibleToDouble_UInt32IConvertibleToDouble_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint32_UInt32IConvertibleToDouble_UInt32IConvertibleToDouble_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint32\\UInt32IConvertibleToDouble\\UInt32IConvertibleToDouble.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

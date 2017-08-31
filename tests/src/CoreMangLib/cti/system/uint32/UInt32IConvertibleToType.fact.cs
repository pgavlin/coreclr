using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint32_UInt32IConvertibleToType_UInt32IConvertibleToType_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint32_UInt32IConvertibleToType_UInt32IConvertibleToType_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint32\\UInt32IConvertibleToType\\UInt32IConvertibleToType.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

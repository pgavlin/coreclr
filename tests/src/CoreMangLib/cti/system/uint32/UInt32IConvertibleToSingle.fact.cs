using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint32_UInt32IConvertibleToSingle_UInt32IConvertibleToSingle_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint32_UInt32IConvertibleToSingle_UInt32IConvertibleToSingle_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint32\\UInt32IConvertibleToSingle\\UInt32IConvertibleToSingle.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

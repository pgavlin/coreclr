using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint32_UInt32GetHashCode_UInt32GetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint32_UInt32GetHashCode_UInt32GetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint32\\UInt32GetHashCode\\UInt32GetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

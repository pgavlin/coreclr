using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint64_UInt64GetHashCode_UInt64GetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint64_UInt64GetHashCode_UInt64GetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint64\\UInt64GetHashCode\\UInt64GetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint64_UInt64MaxValue_UInt64MaxValue_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint64_UInt64MaxValue_UInt64MaxValue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint64\\UInt64MaxValue\\UInt64MaxValue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint64_UInt64ToString2_UInt64ToString2_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint64_UInt64ToString2_UInt64ToString2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint64\\UInt64ToString2\\UInt64ToString2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

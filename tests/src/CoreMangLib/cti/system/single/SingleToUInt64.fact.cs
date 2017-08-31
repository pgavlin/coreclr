using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_single_SingleToUInt64_SingleToUInt64_
    {
        [OuterLoop]
        [Fact]
        public void _system_single_SingleToUInt64_SingleToUInt64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\single\\SingleToUInt64\\SingleToUInt64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

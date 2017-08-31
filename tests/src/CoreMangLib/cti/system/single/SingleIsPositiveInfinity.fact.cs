using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_single_SingleIsPositiveInfinity_SingleIsPositiveInfinity_
    {
        [OuterLoop]
        [Fact]
        public void _system_single_SingleIsPositiveInfinity_SingleIsPositiveInfinity_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\single\\SingleIsPositiveInfinity\\SingleIsPositiveInfinity.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

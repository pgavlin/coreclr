using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_single_SingleIsNegativeInfinity_SingleIsNegativeInfinity_
    {
        [OuterLoop]
        [Fact]
        public void _system_single_SingleIsNegativeInfinity_SingleIsNegativeInfinity_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\single\\SingleIsNegativeInfinity\\SingleIsNegativeInfinity.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

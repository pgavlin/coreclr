using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_single_SingleIsInfinity_SingleIsInfinity_
    {
        [OuterLoop]
        [Fact]
        public void _system_single_SingleIsInfinity_SingleIsInfinity_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\single\\SingleIsInfinity\\SingleIsInfinity.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

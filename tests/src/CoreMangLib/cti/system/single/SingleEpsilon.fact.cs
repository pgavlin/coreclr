using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_single_SingleEpsilon_SingleEpsilon_
    {
        [OuterLoop]
        [Fact]
        public void _system_single_SingleEpsilon_SingleEpsilon_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\single\\SingleEpsilon\\SingleEpsilon.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

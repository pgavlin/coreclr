using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_random_RandomNextBytes_RandomNextBytes_
    {
        [OuterLoop]
        [Fact]
        public void _system_random_RandomNextBytes_RandomNextBytes_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\random\\RandomNextBytes\\RandomNextBytes.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

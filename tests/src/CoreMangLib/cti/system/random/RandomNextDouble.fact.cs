using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_random_RandomNextDouble_RandomNextDouble_
    {
        [OuterLoop]
        [Fact]
        public void _system_random_RandomNextDouble_RandomNextDouble_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\random\\RandomNextDouble\\RandomNextDouble.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

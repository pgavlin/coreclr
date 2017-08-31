using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_random_RandomCtor2_RandomCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_random_RandomCtor2_RandomCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\random\\RandomCtor2\\RandomCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

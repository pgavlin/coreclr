using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_random_RandomCtor1_RandomCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_random_RandomCtor1_RandomCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\random\\RandomCtor1\\RandomCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

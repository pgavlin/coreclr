using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_simplenonlocalexitnestedintrycatch_r_simplenonlocalexitnestedintrycatch_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_simplenonlocalexitnestedintrycatch_r_simplenonlocalexitnestedintrycatch_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\simplenonlocalexitnestedintrycatch_r\\simplenonlocalexitnestedintrycatch_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

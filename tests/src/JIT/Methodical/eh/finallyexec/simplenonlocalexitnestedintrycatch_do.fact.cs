using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_simplenonlocalexitnestedintrycatch_do_simplenonlocalexitnestedintrycatch_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_simplenonlocalexitnestedintrycatch_do_simplenonlocalexitnestedintrycatch_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\simplenonlocalexitnestedintrycatch_do\\simplenonlocalexitnestedintrycatch_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

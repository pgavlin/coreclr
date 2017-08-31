using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_simplenonlocalexitnestedintrycatch_ro_simplenonlocalexitnestedintrycatch_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_simplenonlocalexitnestedintrycatch_ro_simplenonlocalexitnestedintrycatch_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\simplenonlocalexitnestedintrycatch_ro\\simplenonlocalexitnestedintrycatch_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

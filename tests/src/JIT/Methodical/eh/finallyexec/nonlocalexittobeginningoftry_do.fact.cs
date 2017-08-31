using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_nonlocalexittobeginningoftry_do_nonlocalexittobeginningoftry_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_nonlocalexittobeginningoftry_do_nonlocalexittobeginningoftry_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\nonlocalexittobeginningoftry_do\\nonlocalexittobeginningoftry_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

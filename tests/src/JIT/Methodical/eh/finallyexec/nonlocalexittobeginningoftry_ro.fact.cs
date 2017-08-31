using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_nonlocalexittobeginningoftry_ro_nonlocalexittobeginningoftry_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_nonlocalexittobeginningoftry_ro_nonlocalexittobeginningoftry_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\nonlocalexittobeginningoftry_ro\\nonlocalexittobeginningoftry_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

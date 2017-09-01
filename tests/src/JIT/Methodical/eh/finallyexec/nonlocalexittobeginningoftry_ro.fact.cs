using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_finallyexec_nonlocalexittobeginningoftry_ro_nonlocalexittobeginningoftry_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_nonlocalexittobeginningoftry_ro_nonlocalexittobeginningoftry_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\nonlocalexittobeginningoftry_ro\\nonlocalexittobeginningoftry_ro.cmd");
        }
    }
}

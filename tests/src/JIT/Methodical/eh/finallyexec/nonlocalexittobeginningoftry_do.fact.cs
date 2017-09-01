using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_finallyexec_nonlocalexittobeginningoftry_do_nonlocalexittobeginningoftry_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_nonlocalexittobeginningoftry_do_nonlocalexittobeginningoftry_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\nonlocalexittobeginningoftry_do\\nonlocalexittobeginningoftry_do.cmd");
        }
    }
}

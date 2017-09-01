using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_finallyexec_nonlocalexittobeginningoftry_r_nonlocalexittobeginningoftry_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_nonlocalexittobeginningoftry_r_nonlocalexittobeginningoftry_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\nonlocalexittobeginningoftry_r\\nonlocalexittobeginningoftry_r.cmd");
        }
    }
}

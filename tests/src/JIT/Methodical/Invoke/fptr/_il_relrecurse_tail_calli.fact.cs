using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Invoke_fptr__il_relrecurse_tail_calli__il_relrecurse_tail_calli_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__il_relrecurse_tail_calli__il_relrecurse_tail_calli_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_relrecurse_tail_calli\\_il_relrecurse_tail_calli.cmd");
        }
    }
}

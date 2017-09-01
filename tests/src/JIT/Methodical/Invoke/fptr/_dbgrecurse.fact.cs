using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Invoke_fptr__dbgrecurse__dbgrecurse_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__dbgrecurse__dbgrecurse_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_dbgrecurse\\_dbgrecurse.cmd");
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Invoke_fptr__il_dbgvalftn__il_dbgvalftn_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__il_dbgvalftn__il_dbgvalftn_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_dbgvalftn\\_il_dbgvalftn.cmd");
        }
    }
}

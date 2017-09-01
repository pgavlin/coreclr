using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Invoke_fptr__il_dbginstftn__il_dbginstftn_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__il_dbginstftn__il_dbginstftn_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_dbginstftn\\_il_dbginstftn.cmd");
        }
    }
}

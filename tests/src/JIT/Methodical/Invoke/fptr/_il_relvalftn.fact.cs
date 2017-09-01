using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Invoke_fptr__il_relvalftn__il_relvalftn_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__il_relvalftn__il_relvalftn_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_relvalftn\\_il_relvalftn.cmd");
        }
    }
}

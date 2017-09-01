using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Invoke_implicit__il_relobjref__il_relobjref_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_implicit__il_relobjref__il_relobjref_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\implicit\\_il_relobjref\\_il_relobjref.cmd");
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _Misc_SIDEEFFECTS_SideEffects_SideEffects_
    {
        [OuterLoop]
        [Fact]
        public void _Misc_SIDEEFFECTS_SideEffects_SideEffects_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\Misc\\SIDEEFFECTS\\SideEffects\\SideEffects.cmd");
        }
    }
}

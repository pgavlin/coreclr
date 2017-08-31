using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _Misc_SIDEEFFECTS_SideEffects_SideEffects_
    {
        [OuterLoop]
        [Fact]
        public void _Misc_SIDEEFFECTS_SideEffects_SideEffects_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\Misc\\SIDEEFFECTS\\SideEffects\\SideEffects.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

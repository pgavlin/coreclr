using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _IL_Tailcall_jitTailcall1_jitTailcall1_
    {
        [Fact]
        public void _IL_Tailcall_jitTailcall1_jitTailcall1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\IL\\Tailcall\\jitTailcall1\\jitTailcall1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

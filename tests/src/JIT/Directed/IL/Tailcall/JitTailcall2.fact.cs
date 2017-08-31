using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _IL_Tailcall_JitTailcall2_JitTailcall2_
    {
        [Fact]
        public void _IL_Tailcall_JitTailcall2_JitTailcall2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\IL\\Tailcall\\JitTailcall2\\JitTailcall2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_dbgcompat_r4_r8__il_dbgcompat_r4_r8_
    {
        [OuterLoop]
        [Fact]
        public void _tailcall__il_dbgcompat_r4_r8__il_dbgcompat_r4_r8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_dbgcompat_r4_r8\\_il_dbgcompat_r4_r8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

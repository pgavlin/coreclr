using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_dbgcompat_i_u2__il_dbgcompat_i_u2_
    {
        [OuterLoop]
        [Fact]
        public void _tailcall__il_dbgcompat_i_u2__il_dbgcompat_i_u2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_dbgcompat_i_u2\\_il_dbgcompat_i_u2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_dbgcompat_r4_r8_inl__il_dbgcompat_r4_r8_inl_
    {
        [OuterLoop]
        [Fact]
        public void _tailcall__il_dbgcompat_r4_r8_inl__il_dbgcompat_r4_r8_inl_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_dbgcompat_r4_r8_inl\\_il_dbgcompat_r4_r8_inl.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

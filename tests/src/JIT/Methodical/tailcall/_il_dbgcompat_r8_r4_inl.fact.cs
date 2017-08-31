using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_dbgcompat_r8_r4_inl__il_dbgcompat_r8_r4_inl_
    {
        [OuterLoop]
        [Fact]
        public void _tailcall__il_dbgcompat_r8_r4_inl__il_dbgcompat_r8_r4_inl_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_dbgcompat_r8_r4_inl\\_il_dbgcompat_r8_r4_inl.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

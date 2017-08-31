using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_dbgcompat_i4_i1__il_dbgcompat_i4_i1_
    {
        [OuterLoop]
        [Fact]
        public void _tailcall__il_dbgcompat_i4_i1__il_dbgcompat_i4_i1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_dbgcompat_i4_i1\\_il_dbgcompat_i4_i1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

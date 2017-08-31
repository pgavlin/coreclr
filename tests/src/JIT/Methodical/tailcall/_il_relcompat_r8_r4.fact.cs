using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_relcompat_r8_r4__il_relcompat_r8_r4_
    {
        [OuterLoop]
        [Fact]
        public void _tailcall__il_relcompat_r8_r4__il_relcompat_r8_r4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_relcompat_r8_r4\\_il_relcompat_r8_r4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_relcompat_i4_u__il_relcompat_i4_u_
    {
        [Fact]
        public void _tailcall__il_relcompat_i4_u__il_relcompat_i4_u_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_relcompat_i4_u\\_il_relcompat_i4_u.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

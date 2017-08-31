using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_relcompat_v__il_relcompat_v_
    {
        [Fact]
        public void _tailcall__il_relcompat_v__il_relcompat_v_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_relcompat_v\\_il_relcompat_v.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

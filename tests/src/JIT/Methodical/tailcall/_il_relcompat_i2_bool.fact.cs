using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_relcompat_i2_bool__il_relcompat_i2_bool_
    {
        [OuterLoop]
        [Fact]
        public void _tailcall__il_relcompat_i2_bool__il_relcompat_i2_bool_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_relcompat_i2_bool\\_il_relcompat_i2_bool.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

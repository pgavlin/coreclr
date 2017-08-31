using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_relcompat_enum__il_relcompat_enum_
    {
        [Fact]
        public void _tailcall__il_relcompat_enum__il_relcompat_enum_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_relcompat_enum\\_il_relcompat_enum.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_relcompat_obj__il_relcompat_obj_
    {
        [Fact]
        public void _tailcall__il_relcompat_obj__il_relcompat_obj_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_relcompat_obj\\_il_relcompat_obj.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

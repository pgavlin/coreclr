using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_reltest_void__il_reltest_void_
    {
        [Fact]
        public void _tailcall__il_reltest_void__il_reltest_void_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_reltest_void\\_il_reltest_void.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

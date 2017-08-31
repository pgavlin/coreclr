using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _tailcall_tailcall_tailcall_
    {
        [Fact]
        public void _tailcall_tailcall_tailcall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\tailcall\\tailcall\\tailcall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

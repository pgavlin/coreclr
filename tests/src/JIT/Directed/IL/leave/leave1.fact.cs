using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _IL_leave_leave1_leave1_
    {
        [Fact]
        public void _IL_leave_leave1_leave1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\IL\\leave\\leave1\\leave1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

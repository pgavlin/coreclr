using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany_virtcall_virtcall_
    {
        [Fact]
        public void _refany_virtcall_virtcall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\virtcall\\virtcall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

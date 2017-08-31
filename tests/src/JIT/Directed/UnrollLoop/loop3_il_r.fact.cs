using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _UnrollLoop_loop3_il_r_loop3_il_r_
    {
        [Fact]
        public void _UnrollLoop_loop3_il_r_loop3_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\UnrollLoop\\loop3_il_r\\loop3_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

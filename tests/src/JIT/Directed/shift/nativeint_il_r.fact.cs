using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_nativeint_il_r_nativeint_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_nativeint_il_r_nativeint_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\nativeint_il_r\\nativeint_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

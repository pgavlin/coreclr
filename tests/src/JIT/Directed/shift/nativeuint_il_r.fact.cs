using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_nativeuint_il_r_nativeuint_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_nativeuint_il_r_nativeuint_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\nativeuint_il_r\\nativeuint_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_nativeuint_il_d_nativeuint_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _shift_nativeuint_il_d_nativeuint_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\nativeuint_il_d\\nativeuint_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

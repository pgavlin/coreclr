using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_nativeuint_il_r_nativeuint_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_nativeuint_il_r_nativeuint_il_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\nativeuint_il_r\\nativeuint_il_r.cmd");
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_nativeuint_il_d_nativeuint_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _shift_nativeuint_il_d_nativeuint_il_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\nativeuint_il_d\\nativeuint_il_d.cmd");
        }
    }
}

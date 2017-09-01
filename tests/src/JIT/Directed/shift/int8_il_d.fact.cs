using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_int8_il_d_int8_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int8_il_d_int8_il_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int8_il_d\\int8_il_d.cmd");
        }
    }
}

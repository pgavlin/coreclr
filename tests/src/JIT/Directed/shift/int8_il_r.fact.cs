using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_int8_il_r_int8_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int8_il_r_int8_il_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int8_il_r\\int8_il_r.cmd");
        }
    }
}

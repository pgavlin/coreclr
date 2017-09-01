using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_int16_cs_d_int16_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int16_cs_d_int16_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int16_cs_d\\int16_cs_d.cmd");
        }
    }
}

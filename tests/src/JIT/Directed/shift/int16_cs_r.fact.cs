using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_int16_cs_r_int16_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int16_cs_r_int16_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int16_cs_r\\int16_cs_r.cmd");
        }
    }
}

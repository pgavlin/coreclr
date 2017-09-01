using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint8_cs_r_uint8_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint8_cs_r_uint8_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint8_cs_r\\uint8_cs_r.cmd");
        }
    }
}

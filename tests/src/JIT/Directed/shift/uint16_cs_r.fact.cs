using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint16_cs_r_uint16_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint16_cs_r_uint16_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint16_cs_r\\uint16_cs_r.cmd");
        }
    }
}

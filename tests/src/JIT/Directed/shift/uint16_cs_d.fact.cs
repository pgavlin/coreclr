using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint16_cs_d_uint16_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint16_cs_d_uint16_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint16_cs_d\\uint16_cs_d.cmd");
        }
    }
}

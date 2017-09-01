using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint32_cs_d_uint32_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint32_cs_d_uint32_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint32_cs_d\\uint32_cs_d.cmd");
        }
    }
}

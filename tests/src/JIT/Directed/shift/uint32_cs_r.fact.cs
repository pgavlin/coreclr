using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint32_cs_r_uint32_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint32_cs_r_uint32_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint32_cs_r\\uint32_cs_r.cmd");
        }
    }
}

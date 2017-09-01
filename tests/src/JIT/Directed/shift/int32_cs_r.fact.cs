using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_int32_cs_r_int32_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int32_cs_r_int32_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int32_cs_r\\int32_cs_r.cmd");
        }
    }
}

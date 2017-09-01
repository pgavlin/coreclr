using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_int32_cs_d_int32_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int32_cs_d_int32_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int32_cs_d\\int32_cs_d.cmd");
        }
    }
}

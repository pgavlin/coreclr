using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_int32_r_int32_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int32_r_int32_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int32_r\\int32_r.cmd");
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_int16_r_int16_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int16_r_int16_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int16_r\\int16_r.cmd");
        }
    }
}

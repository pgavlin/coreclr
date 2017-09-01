using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_int16_d_int16_d_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int16_d_int16_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int16_d\\int16_d.cmd");
        }
    }
}

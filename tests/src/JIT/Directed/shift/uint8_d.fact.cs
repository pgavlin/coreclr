using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint8_d_uint8_d_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint8_d_uint8_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint8_d\\uint8_d.cmd");
        }
    }
}

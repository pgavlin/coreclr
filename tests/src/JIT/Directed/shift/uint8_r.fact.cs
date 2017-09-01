using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint8_r_uint8_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint8_r_uint8_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint8_r\\uint8_r.cmd");
        }
    }
}

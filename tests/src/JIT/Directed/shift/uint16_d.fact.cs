using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint16_d_uint16_d_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint16_d_uint16_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint16_d\\uint16_d.cmd");
        }
    }
}

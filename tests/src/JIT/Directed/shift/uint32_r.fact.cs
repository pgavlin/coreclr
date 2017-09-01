using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint32_r_uint32_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint32_r_uint32_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint32_r\\uint32_r.cmd");
        }
    }
}

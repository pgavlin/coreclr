using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint64_d_uint64_d_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint64_d_uint64_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint64_d\\uint64_d.cmd");
        }
    }
}

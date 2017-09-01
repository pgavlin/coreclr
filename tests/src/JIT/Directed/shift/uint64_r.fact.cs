using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint64_r_uint64_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint64_r_uint64_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint64_r\\uint64_r.cmd");
        }
    }
}

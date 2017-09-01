using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_int64_d_int64_d_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int64_d_int64_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int64_d\\int64_d.cmd");
        }
    }
}

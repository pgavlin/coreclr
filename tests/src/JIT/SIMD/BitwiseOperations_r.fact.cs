using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _BitwiseOperations_r_BitwiseOperations_r_
    {
        [Fact]
        public void _BitwiseOperations_r_BitwiseOperations_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\BitwiseOperations_r\\BitwiseOperations_r.cmd");
        }
    }
}

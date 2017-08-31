using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _BitwiseOperations_r_BitwiseOperations_r_
    {
        [Fact]
        public void _BitwiseOperations_r_BitwiseOperations_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\BitwiseOperations_r\\BitwiseOperations_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

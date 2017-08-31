using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _BitwiseOperations_ro_BitwiseOperations_ro_
    {
        [Fact]
        public void _BitwiseOperations_ro_BitwiseOperations_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\BitwiseOperations_ro\\BitwiseOperations_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
